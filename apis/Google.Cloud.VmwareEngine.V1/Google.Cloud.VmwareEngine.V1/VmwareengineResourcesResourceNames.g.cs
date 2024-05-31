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
using gcvv = Google.Cloud.VmwareEngine.V1;
using sys = System;

namespace Google.Cloud.VmwareEngine.V1
{
    /// <summary>Resource name for the <c>PrivateCloud</c> resource.</summary>
    public sealed partial class PrivateCloudName : gax::IResourceName, sys::IEquatable<PrivateCloudName>
    {
        /// <summary>The possible contents of <see cref="PrivateCloudName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}</c>
            /// .
            /// </summary>
            ProjectLocationPrivateCloud = 1,
        }

        private static gax::PathTemplate s_projectLocationPrivateCloud = new gax::PathTemplate("projects/{project}/locations/{location}/privateClouds/{private_cloud}");

        /// <summary>Creates a <see cref="PrivateCloudName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PrivateCloudName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PrivateCloudName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PrivateCloudName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PrivateCloudName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PrivateCloudName"/> constructed from the provided ids.</returns>
        public static PrivateCloudName FromProjectLocationPrivateCloud(string projectId, string locationId, string privateCloudId) =>
            new PrivateCloudName(ResourceNameType.ProjectLocationPrivateCloud, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), privateCloudId: gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloudId, nameof(privateCloudId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PrivateCloudName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PrivateCloudName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string privateCloudId) =>
            FormatProjectLocationPrivateCloud(projectId, locationId, privateCloudId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PrivateCloudName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PrivateCloudName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}</c>.
        /// </returns>
        public static string FormatProjectLocationPrivateCloud(string projectId, string locationId, string privateCloudId) =>
            s_projectLocationPrivateCloud.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloudId, nameof(privateCloudId)));

        /// <summary>Parses the given resource name string into a new <see cref="PrivateCloudName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/privateClouds/{private_cloud}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="privateCloudName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PrivateCloudName"/> if successful.</returns>
        public static PrivateCloudName Parse(string privateCloudName) => Parse(privateCloudName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PrivateCloudName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/privateClouds/{private_cloud}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="privateCloudName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PrivateCloudName"/> if successful.</returns>
        public static PrivateCloudName Parse(string privateCloudName, bool allowUnparsed) =>
            TryParse(privateCloudName, allowUnparsed, out PrivateCloudName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PrivateCloudName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/privateClouds/{private_cloud}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="privateCloudName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PrivateCloudName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string privateCloudName, out PrivateCloudName result) =>
            TryParse(privateCloudName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PrivateCloudName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/privateClouds/{private_cloud}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="privateCloudName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PrivateCloudName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string privateCloudName, bool allowUnparsed, out PrivateCloudName result)
        {
            gax::GaxPreconditions.CheckNotNull(privateCloudName, nameof(privateCloudName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationPrivateCloud.TryParseName(privateCloudName, out resourceName))
            {
                result = FromProjectLocationPrivateCloud(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(privateCloudName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PrivateCloudName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string privateCloudId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            PrivateCloudId = privateCloudId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PrivateCloudName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        public PrivateCloudName(string projectId, string locationId, string privateCloudId) : this(ResourceNameType.ProjectLocationPrivateCloud, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), privateCloudId: gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloudId, nameof(privateCloudId)))
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
        /// The <c>PrivateCloud</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string PrivateCloudId { get; }

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
                case ResourceNameType.ProjectLocationPrivateCloud: return s_projectLocationPrivateCloud.Expand(ProjectId, LocationId, PrivateCloudId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PrivateCloudName);

        /// <inheritdoc/>
        public bool Equals(PrivateCloudName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PrivateCloudName a, PrivateCloudName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PrivateCloudName a, PrivateCloudName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Cluster</c> resource.</summary>
    public sealed partial class ClusterName : gax::IResourceName, sys::IEquatable<ClusterName>
    {
        /// <summary>The possible contents of <see cref="ClusterName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/clusters/{cluster}</c>.
            /// </summary>
            ProjectLocationPrivateCloudCluster = 1,
        }

        private static gax::PathTemplate s_projectLocationPrivateCloudCluster = new gax::PathTemplate("projects/{project}/locations/{location}/privateClouds/{private_cloud}/clusters/{cluster}");

        /// <summary>Creates a <see cref="ClusterName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ClusterName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ClusterName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ClusterName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ClusterName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/clusters/{cluster}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ClusterName"/> constructed from the provided ids.</returns>
        public static ClusterName FromProjectLocationPrivateCloudCluster(string projectId, string locationId, string privateCloudId, string clusterId) =>
            new ClusterName(ResourceNameType.ProjectLocationPrivateCloudCluster, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), privateCloudId: gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloudId, nameof(privateCloudId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/clusters/{cluster}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/clusters/{cluster}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string privateCloudId, string clusterId) =>
            FormatProjectLocationPrivateCloudCluster(projectId, locationId, privateCloudId, clusterId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/clusters/{cluster}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/clusters/{cluster}</c>.
        /// </returns>
        public static string FormatProjectLocationPrivateCloudCluster(string projectId, string locationId, string privateCloudId, string clusterId) =>
            s_projectLocationPrivateCloudCluster.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloudId, nameof(privateCloudId)), gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)));

        /// <summary>Parses the given resource name string into a new <see cref="ClusterName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/clusters/{cluster}</c>
        /// </description>
        /// </item>
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
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/clusters/{cluster}</c>
        /// </description>
        /// </item>
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
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/clusters/{cluster}</c>
        /// </description>
        /// </item>
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
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/clusters/{cluster}</c>
        /// </description>
        /// </item>
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
            if (s_projectLocationPrivateCloudCluster.TryParseName(clusterName, out resourceName))
            {
                result = FromProjectLocationPrivateCloudCluster(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
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

        private ClusterName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string clusterId = null, string locationId = null, string privateCloudId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ClusterId = clusterId;
            LocationId = locationId;
            PrivateCloudId = privateCloudId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ClusterName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/clusters/{cluster}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        public ClusterName(string projectId, string locationId, string privateCloudId, string clusterId) : this(ResourceNameType.ProjectLocationPrivateCloudCluster, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), privateCloudId: gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloudId, nameof(privateCloudId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)))
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
        /// The <c>PrivateCloud</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string PrivateCloudId { get; }

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
                case ResourceNameType.ProjectLocationPrivateCloudCluster: return s_projectLocationPrivateCloudCluster.Expand(ProjectId, LocationId, PrivateCloudId, ClusterId);
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
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/clusters/{cluster}/nodes/{node}</c>
            /// .
            /// </summary>
            ProjectLocationPrivateCloudClusterNode = 1,
        }

        private static gax::PathTemplate s_projectLocationPrivateCloudClusterNode = new gax::PathTemplate("projects/{project}/locations/{location}/privateClouds/{private_cloud}/clusters/{cluster}/nodes/{node}");

        /// <summary>Creates a <see cref="NodeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="NodeName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static NodeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new NodeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="NodeName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/clusters/{cluster}/nodes/{node}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nodeId">The <c>Node</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="NodeName"/> constructed from the provided ids.</returns>
        public static NodeName FromProjectLocationPrivateCloudClusterNode(string projectId, string locationId, string privateCloudId, string clusterId, string nodeId) =>
            new NodeName(ResourceNameType.ProjectLocationPrivateCloudClusterNode, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), privateCloudId: gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloudId, nameof(privateCloudId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), nodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(nodeId, nameof(nodeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NodeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/clusters/{cluster}/nodes/{node}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nodeId">The <c>Node</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NodeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/clusters/{cluster}/nodes/{node}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string privateCloudId, string clusterId, string nodeId) =>
            FormatProjectLocationPrivateCloudClusterNode(projectId, locationId, privateCloudId, clusterId, nodeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NodeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/clusters/{cluster}/nodes/{node}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nodeId">The <c>Node</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NodeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/clusters/{cluster}/nodes/{node}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationPrivateCloudClusterNode(string projectId, string locationId, string privateCloudId, string clusterId, string nodeId) =>
            s_projectLocationPrivateCloudClusterNode.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloudId, nameof(privateCloudId)), gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), gax::GaxPreconditions.CheckNotNullOrEmpty(nodeId, nameof(nodeId)));

        /// <summary>Parses the given resource name string into a new <see cref="NodeName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/clusters/{cluster}/nodes/{node}</c>
        /// </description>
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
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/clusters/{cluster}/nodes/{node}</c>
        /// </description>
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
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/clusters/{cluster}/nodes/{node}</c>
        /// </description>
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
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/clusters/{cluster}/nodes/{node}</c>
        /// </description>
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
            if (s_projectLocationPrivateCloudClusterNode.TryParseName(nodeName, out resourceName))
            {
                result = FromProjectLocationPrivateCloudClusterNode(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
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

        private NodeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string clusterId = null, string locationId = null, string nodeId = null, string privateCloudId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ClusterId = clusterId;
            LocationId = locationId;
            NodeId = nodeId;
            PrivateCloudId = privateCloudId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="NodeName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/clusters/{cluster}/nodes/{node}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nodeId">The <c>Node</c> ID. Must not be <c>null</c> or empty.</param>
        public NodeName(string projectId, string locationId, string privateCloudId, string clusterId, string nodeId) : this(ResourceNameType.ProjectLocationPrivateCloudClusterNode, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), privateCloudId: gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloudId, nameof(privateCloudId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), nodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(nodeId, nameof(nodeId)))
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
        /// The <c>PrivateCloud</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string PrivateCloudId { get; }

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
                case ResourceNameType.ProjectLocationPrivateCloudClusterNode: return s_projectLocationPrivateCloudClusterNode.Expand(ProjectId, LocationId, PrivateCloudId, ClusterId, NodeId);
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

    /// <summary>Resource name for the <c>ExternalAddress</c> resource.</summary>
    public sealed partial class ExternalAddressName : gax::IResourceName, sys::IEquatable<ExternalAddressName>
    {
        /// <summary>The possible contents of <see cref="ExternalAddressName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/privateClouds/{private_cloud}/externalAddresses/{external_address}</c>
            /// .
            /// </summary>
            ProjectLocationPrivateCloudExternalAddress = 1,
        }

        private static gax::PathTemplate s_projectLocationPrivateCloudExternalAddress = new gax::PathTemplate("projects/{project}/locations/{location}/privateClouds/{private_cloud}/externalAddresses/{external_address}");

        /// <summary>Creates a <see cref="ExternalAddressName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ExternalAddressName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ExternalAddressName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ExternalAddressName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ExternalAddressName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/privateClouds/{private_cloud}/externalAddresses/{external_address}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="externalAddressId">The <c>ExternalAddress</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ExternalAddressName"/> constructed from the provided ids.</returns>
        public static ExternalAddressName FromProjectLocationPrivateCloudExternalAddress(string projectId, string locationId, string privateCloudId, string externalAddressId) =>
            new ExternalAddressName(ResourceNameType.ProjectLocationPrivateCloudExternalAddress, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), privateCloudId: gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloudId, nameof(privateCloudId)), externalAddressId: gax::GaxPreconditions.CheckNotNullOrEmpty(externalAddressId, nameof(externalAddressId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExternalAddressName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/privateClouds/{private_cloud}/externalAddresses/{external_address}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="externalAddressId">The <c>ExternalAddress</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ExternalAddressName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/privateClouds/{private_cloud}/externalAddresses/{external_address}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string privateCloudId, string externalAddressId) =>
            FormatProjectLocationPrivateCloudExternalAddress(projectId, locationId, privateCloudId, externalAddressId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExternalAddressName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/privateClouds/{private_cloud}/externalAddresses/{external_address}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="externalAddressId">The <c>ExternalAddress</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ExternalAddressName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/privateClouds/{private_cloud}/externalAddresses/{external_address}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationPrivateCloudExternalAddress(string projectId, string locationId, string privateCloudId, string externalAddressId) =>
            s_projectLocationPrivateCloudExternalAddress.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloudId, nameof(privateCloudId)), gax::GaxPreconditions.CheckNotNullOrEmpty(externalAddressId, nameof(externalAddressId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ExternalAddressName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/privateClouds/{private_cloud}/externalAddresses/{external_address}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="externalAddressName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ExternalAddressName"/> if successful.</returns>
        public static ExternalAddressName Parse(string externalAddressName) => Parse(externalAddressName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ExternalAddressName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/privateClouds/{private_cloud}/externalAddresses/{external_address}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="externalAddressName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ExternalAddressName"/> if successful.</returns>
        public static ExternalAddressName Parse(string externalAddressName, bool allowUnparsed) =>
            TryParse(externalAddressName, allowUnparsed, out ExternalAddressName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExternalAddressName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/privateClouds/{private_cloud}/externalAddresses/{external_address}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="externalAddressName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExternalAddressName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string externalAddressName, out ExternalAddressName result) =>
            TryParse(externalAddressName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExternalAddressName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/privateClouds/{private_cloud}/externalAddresses/{external_address}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="externalAddressName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExternalAddressName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string externalAddressName, bool allowUnparsed, out ExternalAddressName result)
        {
            gax::GaxPreconditions.CheckNotNull(externalAddressName, nameof(externalAddressName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationPrivateCloudExternalAddress.TryParseName(externalAddressName, out resourceName))
            {
                result = FromProjectLocationPrivateCloudExternalAddress(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(externalAddressName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ExternalAddressName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string externalAddressId = null, string locationId = null, string privateCloudId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ExternalAddressId = externalAddressId;
            LocationId = locationId;
            PrivateCloudId = privateCloudId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ExternalAddressName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/privateClouds/{private_cloud}/externalAddresses/{external_address}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="externalAddressId">The <c>ExternalAddress</c> ID. Must not be <c>null</c> or empty.</param>
        public ExternalAddressName(string projectId, string locationId, string privateCloudId, string externalAddressId) : this(ResourceNameType.ProjectLocationPrivateCloudExternalAddress, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), privateCloudId: gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloudId, nameof(privateCloudId)), externalAddressId: gax::GaxPreconditions.CheckNotNullOrEmpty(externalAddressId, nameof(externalAddressId)))
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
        /// The <c>ExternalAddress</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ExternalAddressId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>PrivateCloud</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string PrivateCloudId { get; }

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
                case ResourceNameType.ProjectLocationPrivateCloudExternalAddress: return s_projectLocationPrivateCloudExternalAddress.Expand(ProjectId, LocationId, PrivateCloudId, ExternalAddressId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ExternalAddressName);

        /// <inheritdoc/>
        public bool Equals(ExternalAddressName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ExternalAddressName a, ExternalAddressName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ExternalAddressName a, ExternalAddressName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Subnet</c> resource.</summary>
    public sealed partial class SubnetName : gax::IResourceName, sys::IEquatable<SubnetName>
    {
        /// <summary>The possible contents of <see cref="SubnetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/subnets/{subnet}</c>.
            /// </summary>
            ProjectLocationPrivateCloudSubnet = 1,
        }

        private static gax::PathTemplate s_projectLocationPrivateCloudSubnet = new gax::PathTemplate("projects/{project}/locations/{location}/privateClouds/{private_cloud}/subnets/{subnet}");

        /// <summary>Creates a <see cref="SubnetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SubnetName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SubnetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SubnetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SubnetName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/subnets/{subnet}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subnetId">The <c>Subnet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SubnetName"/> constructed from the provided ids.</returns>
        public static SubnetName FromProjectLocationPrivateCloudSubnet(string projectId, string locationId, string privateCloudId, string subnetId) =>
            new SubnetName(ResourceNameType.ProjectLocationPrivateCloudSubnet, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), privateCloudId: gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloudId, nameof(privateCloudId)), subnetId: gax::GaxPreconditions.CheckNotNullOrEmpty(subnetId, nameof(subnetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SubnetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/subnets/{subnet}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subnetId">The <c>Subnet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SubnetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/subnets/{subnet}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string privateCloudId, string subnetId) =>
            FormatProjectLocationPrivateCloudSubnet(projectId, locationId, privateCloudId, subnetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SubnetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/subnets/{subnet}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subnetId">The <c>Subnet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SubnetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/subnets/{subnet}</c>.
        /// </returns>
        public static string FormatProjectLocationPrivateCloudSubnet(string projectId, string locationId, string privateCloudId, string subnetId) =>
            s_projectLocationPrivateCloudSubnet.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloudId, nameof(privateCloudId)), gax::GaxPreconditions.CheckNotNullOrEmpty(subnetId, nameof(subnetId)));

        /// <summary>Parses the given resource name string into a new <see cref="SubnetName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/subnets/{subnet}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="subnetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SubnetName"/> if successful.</returns>
        public static SubnetName Parse(string subnetName) => Parse(subnetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SubnetName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/subnets/{subnet}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="subnetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SubnetName"/> if successful.</returns>
        public static SubnetName Parse(string subnetName, bool allowUnparsed) =>
            TryParse(subnetName, allowUnparsed, out SubnetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SubnetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/subnets/{subnet}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="subnetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SubnetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string subnetName, out SubnetName result) => TryParse(subnetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SubnetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/subnets/{subnet}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="subnetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SubnetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string subnetName, bool allowUnparsed, out SubnetName result)
        {
            gax::GaxPreconditions.CheckNotNull(subnetName, nameof(subnetName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationPrivateCloudSubnet.TryParseName(subnetName, out resourceName))
            {
                result = FromProjectLocationPrivateCloudSubnet(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(subnetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SubnetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string privateCloudId = null, string projectId = null, string subnetId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            PrivateCloudId = privateCloudId;
            ProjectId = projectId;
            SubnetId = subnetId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SubnetName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/subnets/{subnet}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subnetId">The <c>Subnet</c> ID. Must not be <c>null</c> or empty.</param>
        public SubnetName(string projectId, string locationId, string privateCloudId, string subnetId) : this(ResourceNameType.ProjectLocationPrivateCloudSubnet, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), privateCloudId: gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloudId, nameof(privateCloudId)), subnetId: gax::GaxPreconditions.CheckNotNullOrEmpty(subnetId, nameof(subnetId)))
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
        /// The <c>PrivateCloud</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string PrivateCloudId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Subnet</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SubnetId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationPrivateCloudSubnet: return s_projectLocationPrivateCloudSubnet.Expand(ProjectId, LocationId, PrivateCloudId, SubnetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SubnetName);

        /// <inheritdoc/>
        public bool Equals(SubnetName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SubnetName a, SubnetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SubnetName a, SubnetName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ExternalAccessRule</c> resource.</summary>
    public sealed partial class ExternalAccessRuleName : gax::IResourceName, sys::IEquatable<ExternalAccessRuleName>
    {
        /// <summary>The possible contents of <see cref="ExternalAccessRuleName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/networkPolicies/{network_policy}/externalAccessRules/{external_access_rule}</c>
            /// .
            /// </summary>
            ProjectLocationNetworkPolicyExternalAccessRule = 1,
        }

        private static gax::PathTemplate s_projectLocationNetworkPolicyExternalAccessRule = new gax::PathTemplate("projects/{project}/locations/{location}/networkPolicies/{network_policy}/externalAccessRules/{external_access_rule}");

        /// <summary>Creates a <see cref="ExternalAccessRuleName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ExternalAccessRuleName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ExternalAccessRuleName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ExternalAccessRuleName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ExternalAccessRuleName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/networkPolicies/{network_policy}/externalAccessRules/{external_access_rule}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkPolicyId">The <c>NetworkPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="externalAccessRuleId">
        /// The <c>ExternalAccessRule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="ExternalAccessRuleName"/> constructed from the provided ids.</returns>
        public static ExternalAccessRuleName FromProjectLocationNetworkPolicyExternalAccessRule(string projectId, string locationId, string networkPolicyId, string externalAccessRuleId) =>
            new ExternalAccessRuleName(ResourceNameType.ProjectLocationNetworkPolicyExternalAccessRule, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), networkPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkPolicyId, nameof(networkPolicyId)), externalAccessRuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(externalAccessRuleId, nameof(externalAccessRuleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExternalAccessRuleName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/networkPolicies/{network_policy}/externalAccessRules/{external_access_rule}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkPolicyId">The <c>NetworkPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="externalAccessRuleId">
        /// The <c>ExternalAccessRule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ExternalAccessRuleName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/networkPolicies/{network_policy}/externalAccessRules/{external_access_rule}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string networkPolicyId, string externalAccessRuleId) =>
            FormatProjectLocationNetworkPolicyExternalAccessRule(projectId, locationId, networkPolicyId, externalAccessRuleId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExternalAccessRuleName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/networkPolicies/{network_policy}/externalAccessRules/{external_access_rule}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkPolicyId">The <c>NetworkPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="externalAccessRuleId">
        /// The <c>ExternalAccessRule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ExternalAccessRuleName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/networkPolicies/{network_policy}/externalAccessRules/{external_access_rule}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationNetworkPolicyExternalAccessRule(string projectId, string locationId, string networkPolicyId, string externalAccessRuleId) =>
            s_projectLocationNetworkPolicyExternalAccessRule.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(networkPolicyId, nameof(networkPolicyId)), gax::GaxPreconditions.CheckNotNullOrEmpty(externalAccessRuleId, nameof(externalAccessRuleId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ExternalAccessRuleName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/networkPolicies/{network_policy}/externalAccessRules/{external_access_rule}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="externalAccessRuleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ExternalAccessRuleName"/> if successful.</returns>
        public static ExternalAccessRuleName Parse(string externalAccessRuleName) => Parse(externalAccessRuleName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ExternalAccessRuleName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/networkPolicies/{network_policy}/externalAccessRules/{external_access_rule}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="externalAccessRuleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ExternalAccessRuleName"/> if successful.</returns>
        public static ExternalAccessRuleName Parse(string externalAccessRuleName, bool allowUnparsed) =>
            TryParse(externalAccessRuleName, allowUnparsed, out ExternalAccessRuleName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExternalAccessRuleName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/networkPolicies/{network_policy}/externalAccessRules/{external_access_rule}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="externalAccessRuleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExternalAccessRuleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string externalAccessRuleName, out ExternalAccessRuleName result) =>
            TryParse(externalAccessRuleName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExternalAccessRuleName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/networkPolicies/{network_policy}/externalAccessRules/{external_access_rule}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="externalAccessRuleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExternalAccessRuleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string externalAccessRuleName, bool allowUnparsed, out ExternalAccessRuleName result)
        {
            gax::GaxPreconditions.CheckNotNull(externalAccessRuleName, nameof(externalAccessRuleName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationNetworkPolicyExternalAccessRule.TryParseName(externalAccessRuleName, out resourceName))
            {
                result = FromProjectLocationNetworkPolicyExternalAccessRule(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(externalAccessRuleName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ExternalAccessRuleName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string externalAccessRuleId = null, string locationId = null, string networkPolicyId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ExternalAccessRuleId = externalAccessRuleId;
            LocationId = locationId;
            NetworkPolicyId = networkPolicyId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ExternalAccessRuleName"/> class from the component parts of
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/networkPolicies/{network_policy}/externalAccessRules/{external_access_rule}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkPolicyId">The <c>NetworkPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="externalAccessRuleId">
        /// The <c>ExternalAccessRule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public ExternalAccessRuleName(string projectId, string locationId, string networkPolicyId, string externalAccessRuleId) : this(ResourceNameType.ProjectLocationNetworkPolicyExternalAccessRule, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), networkPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkPolicyId, nameof(networkPolicyId)), externalAccessRuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(externalAccessRuleId, nameof(externalAccessRuleId)))
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
        /// The <c>ExternalAccessRule</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string ExternalAccessRuleId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>NetworkPolicy</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string NetworkPolicyId { get; }

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
                case ResourceNameType.ProjectLocationNetworkPolicyExternalAccessRule: return s_projectLocationNetworkPolicyExternalAccessRule.Expand(ProjectId, LocationId, NetworkPolicyId, ExternalAccessRuleId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ExternalAccessRuleName);

        /// <inheritdoc/>
        public bool Equals(ExternalAccessRuleName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ExternalAccessRuleName a, ExternalAccessRuleName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ExternalAccessRuleName a, ExternalAccessRuleName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>LoggingServer</c> resource.</summary>
    public sealed partial class LoggingServerName : gax::IResourceName, sys::IEquatable<LoggingServerName>
    {
        /// <summary>The possible contents of <see cref="LoggingServerName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/loggingServers/{logging_server}</c>
            /// .
            /// </summary>
            ProjectLocationPrivateCloudLoggingServer = 1,
        }

        private static gax::PathTemplate s_projectLocationPrivateCloudLoggingServer = new gax::PathTemplate("projects/{project}/locations/{location}/privateClouds/{private_cloud}/loggingServers/{logging_server}");

        /// <summary>Creates a <see cref="LoggingServerName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LoggingServerName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static LoggingServerName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LoggingServerName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LoggingServerName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/loggingServers/{logging_server}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="loggingServerId">The <c>LoggingServer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LoggingServerName"/> constructed from the provided ids.</returns>
        public static LoggingServerName FromProjectLocationPrivateCloudLoggingServer(string projectId, string locationId, string privateCloudId, string loggingServerId) =>
            new LoggingServerName(ResourceNameType.ProjectLocationPrivateCloudLoggingServer, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), privateCloudId: gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloudId, nameof(privateCloudId)), loggingServerId: gax::GaxPreconditions.CheckNotNullOrEmpty(loggingServerId, nameof(loggingServerId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LoggingServerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/loggingServers/{logging_server}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="loggingServerId">The <c>LoggingServer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LoggingServerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/loggingServers/{logging_server}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string privateCloudId, string loggingServerId) =>
            FormatProjectLocationPrivateCloudLoggingServer(projectId, locationId, privateCloudId, loggingServerId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LoggingServerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/loggingServers/{logging_server}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="loggingServerId">The <c>LoggingServer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LoggingServerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/loggingServers/{logging_server}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationPrivateCloudLoggingServer(string projectId, string locationId, string privateCloudId, string loggingServerId) =>
            s_projectLocationPrivateCloudLoggingServer.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloudId, nameof(privateCloudId)), gax::GaxPreconditions.CheckNotNullOrEmpty(loggingServerId, nameof(loggingServerId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LoggingServerName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/loggingServers/{logging_server}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="loggingServerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LoggingServerName"/> if successful.</returns>
        public static LoggingServerName Parse(string loggingServerName) => Parse(loggingServerName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LoggingServerName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/loggingServers/{logging_server}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="loggingServerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LoggingServerName"/> if successful.</returns>
        public static LoggingServerName Parse(string loggingServerName, bool allowUnparsed) =>
            TryParse(loggingServerName, allowUnparsed, out LoggingServerName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LoggingServerName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/loggingServers/{logging_server}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="loggingServerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LoggingServerName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string loggingServerName, out LoggingServerName result) =>
            TryParse(loggingServerName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LoggingServerName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/loggingServers/{logging_server}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="loggingServerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LoggingServerName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string loggingServerName, bool allowUnparsed, out LoggingServerName result)
        {
            gax::GaxPreconditions.CheckNotNull(loggingServerName, nameof(loggingServerName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationPrivateCloudLoggingServer.TryParseName(loggingServerName, out resourceName))
            {
                result = FromProjectLocationPrivateCloudLoggingServer(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(loggingServerName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private LoggingServerName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string loggingServerId = null, string privateCloudId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            LoggingServerId = loggingServerId;
            PrivateCloudId = privateCloudId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LoggingServerName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/loggingServers/{logging_server}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="loggingServerId">The <c>LoggingServer</c> ID. Must not be <c>null</c> or empty.</param>
        public LoggingServerName(string projectId, string locationId, string privateCloudId, string loggingServerId) : this(ResourceNameType.ProjectLocationPrivateCloudLoggingServer, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), privateCloudId: gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloudId, nameof(privateCloudId)), loggingServerId: gax::GaxPreconditions.CheckNotNullOrEmpty(loggingServerId, nameof(loggingServerId)))
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
        /// The <c>LoggingServer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string LoggingServerId { get; }

        /// <summary>
        /// The <c>PrivateCloud</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string PrivateCloudId { get; }

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
                case ResourceNameType.ProjectLocationPrivateCloudLoggingServer: return s_projectLocationPrivateCloudLoggingServer.Expand(ProjectId, LocationId, PrivateCloudId, LoggingServerId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LoggingServerName);

        /// <inheritdoc/>
        public bool Equals(LoggingServerName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(LoggingServerName a, LoggingServerName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(LoggingServerName a, LoggingServerName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>NodeType</c> resource.</summary>
    public sealed partial class NodeTypeName : gax::IResourceName, sys::IEquatable<NodeTypeName>
    {
        /// <summary>The possible contents of <see cref="NodeTypeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/nodeTypes/{node_type}</c>.
            /// </summary>
            ProjectLocationNodeType = 1,
        }

        private static gax::PathTemplate s_projectLocationNodeType = new gax::PathTemplate("projects/{project}/locations/{location}/nodeTypes/{node_type}");

        /// <summary>Creates a <see cref="NodeTypeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="NodeTypeName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static NodeTypeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new NodeTypeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="NodeTypeName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/nodeTypes/{node_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nodeTypeId">The <c>NodeType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="NodeTypeName"/> constructed from the provided ids.</returns>
        public static NodeTypeName FromProjectLocationNodeType(string projectId, string locationId, string nodeTypeId) =>
            new NodeTypeName(ResourceNameType.ProjectLocationNodeType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), nodeTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(nodeTypeId, nameof(nodeTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NodeTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/nodeTypes/{node_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nodeTypeId">The <c>NodeType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NodeTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/nodeTypes/{node_type}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string nodeTypeId) =>
            FormatProjectLocationNodeType(projectId, locationId, nodeTypeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NodeTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/nodeTypes/{node_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nodeTypeId">The <c>NodeType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NodeTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/nodeTypes/{node_type}</c>.
        /// </returns>
        public static string FormatProjectLocationNodeType(string projectId, string locationId, string nodeTypeId) =>
            s_projectLocationNodeType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(nodeTypeId, nameof(nodeTypeId)));

        /// <summary>Parses the given resource name string into a new <see cref="NodeTypeName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/nodeTypes/{node_type}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="nodeTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="NodeTypeName"/> if successful.</returns>
        public static NodeTypeName Parse(string nodeTypeName) => Parse(nodeTypeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NodeTypeName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/nodeTypes/{node_type}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="nodeTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="NodeTypeName"/> if successful.</returns>
        public static NodeTypeName Parse(string nodeTypeName, bool allowUnparsed) =>
            TryParse(nodeTypeName, allowUnparsed, out NodeTypeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NodeTypeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/nodeTypes/{node_type}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="nodeTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NodeTypeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string nodeTypeName, out NodeTypeName result) => TryParse(nodeTypeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NodeTypeName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/nodeTypes/{node_type}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="nodeTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NodeTypeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string nodeTypeName, bool allowUnparsed, out NodeTypeName result)
        {
            gax::GaxPreconditions.CheckNotNull(nodeTypeName, nameof(nodeTypeName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationNodeType.TryParseName(nodeTypeName, out resourceName))
            {
                result = FromProjectLocationNodeType(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(nodeTypeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private NodeTypeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string nodeTypeId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            NodeTypeId = nodeTypeId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="NodeTypeName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/nodeTypes/{node_type}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nodeTypeId">The <c>NodeType</c> ID. Must not be <c>null</c> or empty.</param>
        public NodeTypeName(string projectId, string locationId, string nodeTypeId) : this(ResourceNameType.ProjectLocationNodeType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), nodeTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(nodeTypeId, nameof(nodeTypeId)))
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
        /// The <c>NodeType</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string NodeTypeId { get; }

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
                case ResourceNameType.ProjectLocationNodeType: return s_projectLocationNodeType.Expand(ProjectId, LocationId, NodeTypeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as NodeTypeName);

        /// <inheritdoc/>
        public bool Equals(NodeTypeName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(NodeTypeName a, NodeTypeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(NodeTypeName a, NodeTypeName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>HcxActivationKey</c> resource.</summary>
    public sealed partial class HcxActivationKeyName : gax::IResourceName, sys::IEquatable<HcxActivationKeyName>
    {
        /// <summary>The possible contents of <see cref="HcxActivationKeyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/privateClouds/{private_cloud}/hcxActivationKeys/{hcx_activation_key}</c>
            /// .
            /// </summary>
            ProjectLocationPrivateCloudHcxActivationKey = 1,
        }

        private static gax::PathTemplate s_projectLocationPrivateCloudHcxActivationKey = new gax::PathTemplate("projects/{project}/locations/{location}/privateClouds/{private_cloud}/hcxActivationKeys/{hcx_activation_key}");

        /// <summary>Creates a <see cref="HcxActivationKeyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="HcxActivationKeyName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static HcxActivationKeyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new HcxActivationKeyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="HcxActivationKeyName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/privateClouds/{private_cloud}/hcxActivationKeys/{hcx_activation_key}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hcxActivationKeyId">The <c>HcxActivationKey</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="HcxActivationKeyName"/> constructed from the provided ids.</returns>
        public static HcxActivationKeyName FromProjectLocationPrivateCloudHcxActivationKey(string projectId, string locationId, string privateCloudId, string hcxActivationKeyId) =>
            new HcxActivationKeyName(ResourceNameType.ProjectLocationPrivateCloudHcxActivationKey, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), privateCloudId: gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloudId, nameof(privateCloudId)), hcxActivationKeyId: gax::GaxPreconditions.CheckNotNullOrEmpty(hcxActivationKeyId, nameof(hcxActivationKeyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="HcxActivationKeyName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/privateClouds/{private_cloud}/hcxActivationKeys/{hcx_activation_key}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hcxActivationKeyId">The <c>HcxActivationKey</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="HcxActivationKeyName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/privateClouds/{private_cloud}/hcxActivationKeys/{hcx_activation_key}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string privateCloudId, string hcxActivationKeyId) =>
            FormatProjectLocationPrivateCloudHcxActivationKey(projectId, locationId, privateCloudId, hcxActivationKeyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="HcxActivationKeyName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/privateClouds/{private_cloud}/hcxActivationKeys/{hcx_activation_key}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hcxActivationKeyId">The <c>HcxActivationKey</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="HcxActivationKeyName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/privateClouds/{private_cloud}/hcxActivationKeys/{hcx_activation_key}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationPrivateCloudHcxActivationKey(string projectId, string locationId, string privateCloudId, string hcxActivationKeyId) =>
            s_projectLocationPrivateCloudHcxActivationKey.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloudId, nameof(privateCloudId)), gax::GaxPreconditions.CheckNotNullOrEmpty(hcxActivationKeyId, nameof(hcxActivationKeyId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="HcxActivationKeyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/privateClouds/{private_cloud}/hcxActivationKeys/{hcx_activation_key}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="hcxActivationKeyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="HcxActivationKeyName"/> if successful.</returns>
        public static HcxActivationKeyName Parse(string hcxActivationKeyName) => Parse(hcxActivationKeyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="HcxActivationKeyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/privateClouds/{private_cloud}/hcxActivationKeys/{hcx_activation_key}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="hcxActivationKeyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="HcxActivationKeyName"/> if successful.</returns>
        public static HcxActivationKeyName Parse(string hcxActivationKeyName, bool allowUnparsed) =>
            TryParse(hcxActivationKeyName, allowUnparsed, out HcxActivationKeyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="HcxActivationKeyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/privateClouds/{private_cloud}/hcxActivationKeys/{hcx_activation_key}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="hcxActivationKeyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="HcxActivationKeyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string hcxActivationKeyName, out HcxActivationKeyName result) =>
            TryParse(hcxActivationKeyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="HcxActivationKeyName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/privateClouds/{private_cloud}/hcxActivationKeys/{hcx_activation_key}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="hcxActivationKeyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="HcxActivationKeyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string hcxActivationKeyName, bool allowUnparsed, out HcxActivationKeyName result)
        {
            gax::GaxPreconditions.CheckNotNull(hcxActivationKeyName, nameof(hcxActivationKeyName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationPrivateCloudHcxActivationKey.TryParseName(hcxActivationKeyName, out resourceName))
            {
                result = FromProjectLocationPrivateCloudHcxActivationKey(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(hcxActivationKeyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private HcxActivationKeyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string hcxActivationKeyId = null, string locationId = null, string privateCloudId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            HcxActivationKeyId = hcxActivationKeyId;
            LocationId = locationId;
            PrivateCloudId = privateCloudId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="HcxActivationKeyName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/privateClouds/{private_cloud}/hcxActivationKeys/{hcx_activation_key}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hcxActivationKeyId">The <c>HcxActivationKey</c> ID. Must not be <c>null</c> or empty.</param>
        public HcxActivationKeyName(string projectId, string locationId, string privateCloudId, string hcxActivationKeyId) : this(ResourceNameType.ProjectLocationPrivateCloudHcxActivationKey, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), privateCloudId: gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloudId, nameof(privateCloudId)), hcxActivationKeyId: gax::GaxPreconditions.CheckNotNullOrEmpty(hcxActivationKeyId, nameof(hcxActivationKeyId)))
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
        /// The <c>HcxActivationKey</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string HcxActivationKeyId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>PrivateCloud</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string PrivateCloudId { get; }

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
                case ResourceNameType.ProjectLocationPrivateCloudHcxActivationKey: return s_projectLocationPrivateCloudHcxActivationKey.Expand(ProjectId, LocationId, PrivateCloudId, HcxActivationKeyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as HcxActivationKeyName);

        /// <inheritdoc/>
        public bool Equals(HcxActivationKeyName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(HcxActivationKeyName a, HcxActivationKeyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(HcxActivationKeyName a, HcxActivationKeyName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>DnsForwarding</c> resource.</summary>
    public sealed partial class DnsForwardingName : gax::IResourceName, sys::IEquatable<DnsForwardingName>
    {
        /// <summary>The possible contents of <see cref="DnsForwardingName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/dnsForwarding</c>.
            /// </summary>
            ProjectLocationPrivateCloud = 1,
        }

        private static gax::PathTemplate s_projectLocationPrivateCloud = new gax::PathTemplate("projects/{project}/locations/{location}/privateClouds/{private_cloud}/dnsForwarding");

        /// <summary>Creates a <see cref="DnsForwardingName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DnsForwardingName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DnsForwardingName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DnsForwardingName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DnsForwardingName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/dnsForwarding</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DnsForwardingName"/> constructed from the provided ids.</returns>
        public static DnsForwardingName FromProjectLocationPrivateCloud(string projectId, string locationId, string privateCloudId) =>
            new DnsForwardingName(ResourceNameType.ProjectLocationPrivateCloud, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), privateCloudId: gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloudId, nameof(privateCloudId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DnsForwardingName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/dnsForwarding</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DnsForwardingName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/dnsForwarding</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string privateCloudId) =>
            FormatProjectLocationPrivateCloud(projectId, locationId, privateCloudId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DnsForwardingName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/dnsForwarding</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DnsForwardingName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/dnsForwarding</c>.
        /// </returns>
        public static string FormatProjectLocationPrivateCloud(string projectId, string locationId, string privateCloudId) =>
            s_projectLocationPrivateCloud.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloudId, nameof(privateCloudId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DnsForwardingName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/dnsForwarding</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dnsForwardingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DnsForwardingName"/> if successful.</returns>
        public static DnsForwardingName Parse(string dnsForwardingName) => Parse(dnsForwardingName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DnsForwardingName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/dnsForwarding</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dnsForwardingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DnsForwardingName"/> if successful.</returns>
        public static DnsForwardingName Parse(string dnsForwardingName, bool allowUnparsed) =>
            TryParse(dnsForwardingName, allowUnparsed, out DnsForwardingName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DnsForwardingName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/dnsForwarding</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dnsForwardingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DnsForwardingName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dnsForwardingName, out DnsForwardingName result) =>
            TryParse(dnsForwardingName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DnsForwardingName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/dnsForwarding</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dnsForwardingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DnsForwardingName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dnsForwardingName, bool allowUnparsed, out DnsForwardingName result)
        {
            gax::GaxPreconditions.CheckNotNull(dnsForwardingName, nameof(dnsForwardingName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationPrivateCloud.TryParseName(dnsForwardingName, out resourceName))
            {
                result = FromProjectLocationPrivateCloud(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dnsForwardingName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DnsForwardingName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string privateCloudId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            PrivateCloudId = privateCloudId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DnsForwardingName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/privateClouds/{private_cloud}/dnsForwarding</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        public DnsForwardingName(string projectId, string locationId, string privateCloudId) : this(ResourceNameType.ProjectLocationPrivateCloud, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), privateCloudId: gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloudId, nameof(privateCloudId)))
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
        /// The <c>PrivateCloud</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string PrivateCloudId { get; }

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
                case ResourceNameType.ProjectLocationPrivateCloud: return s_projectLocationPrivateCloud.Expand(ProjectId, LocationId, PrivateCloudId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DnsForwardingName);

        /// <inheritdoc/>
        public bool Equals(DnsForwardingName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DnsForwardingName a, DnsForwardingName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DnsForwardingName a, DnsForwardingName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>NetworkPeering</c> resource.</summary>
    public sealed partial class NetworkPeeringName : gax::IResourceName, sys::IEquatable<NetworkPeeringName>
    {
        /// <summary>The possible contents of <see cref="NetworkPeeringName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/networkPeerings/{network_peering}</c>.
            /// </summary>
            ProjectLocationNetworkPeering = 1,
        }

        private static gax::PathTemplate s_projectLocationNetworkPeering = new gax::PathTemplate("projects/{project}/locations/{location}/networkPeerings/{network_peering}");

        /// <summary>Creates a <see cref="NetworkPeeringName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="NetworkPeeringName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static NetworkPeeringName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new NetworkPeeringName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="NetworkPeeringName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/networkPeerings/{network_peering}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkPeeringId">The <c>NetworkPeering</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="NetworkPeeringName"/> constructed from the provided ids.</returns>
        public static NetworkPeeringName FromProjectLocationNetworkPeering(string projectId, string locationId, string networkPeeringId) =>
            new NetworkPeeringName(ResourceNameType.ProjectLocationNetworkPeering, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), networkPeeringId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkPeeringId, nameof(networkPeeringId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NetworkPeeringName"/> with pattern
        /// <c>projects/{project}/locations/{location}/networkPeerings/{network_peering}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkPeeringId">The <c>NetworkPeering</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NetworkPeeringName"/> with pattern
        /// <c>projects/{project}/locations/{location}/networkPeerings/{network_peering}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string networkPeeringId) =>
            FormatProjectLocationNetworkPeering(projectId, locationId, networkPeeringId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NetworkPeeringName"/> with pattern
        /// <c>projects/{project}/locations/{location}/networkPeerings/{network_peering}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkPeeringId">The <c>NetworkPeering</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NetworkPeeringName"/> with pattern
        /// <c>projects/{project}/locations/{location}/networkPeerings/{network_peering}</c>.
        /// </returns>
        public static string FormatProjectLocationNetworkPeering(string projectId, string locationId, string networkPeeringId) =>
            s_projectLocationNetworkPeering.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(networkPeeringId, nameof(networkPeeringId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NetworkPeeringName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/networkPeerings/{network_peering}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="networkPeeringName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="NetworkPeeringName"/> if successful.</returns>
        public static NetworkPeeringName Parse(string networkPeeringName) => Parse(networkPeeringName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NetworkPeeringName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/networkPeerings/{network_peering}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="networkPeeringName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="NetworkPeeringName"/> if successful.</returns>
        public static NetworkPeeringName Parse(string networkPeeringName, bool allowUnparsed) =>
            TryParse(networkPeeringName, allowUnparsed, out NetworkPeeringName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NetworkPeeringName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/networkPeerings/{network_peering}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="networkPeeringName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NetworkPeeringName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string networkPeeringName, out NetworkPeeringName result) =>
            TryParse(networkPeeringName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NetworkPeeringName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/networkPeerings/{network_peering}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="networkPeeringName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NetworkPeeringName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string networkPeeringName, bool allowUnparsed, out NetworkPeeringName result)
        {
            gax::GaxPreconditions.CheckNotNull(networkPeeringName, nameof(networkPeeringName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationNetworkPeering.TryParseName(networkPeeringName, out resourceName))
            {
                result = FromProjectLocationNetworkPeering(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(networkPeeringName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private NetworkPeeringName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string networkPeeringId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            NetworkPeeringId = networkPeeringId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="NetworkPeeringName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/networkPeerings/{network_peering}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkPeeringId">The <c>NetworkPeering</c> ID. Must not be <c>null</c> or empty.</param>
        public NetworkPeeringName(string projectId, string locationId, string networkPeeringId) : this(ResourceNameType.ProjectLocationNetworkPeering, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), networkPeeringId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkPeeringId, nameof(networkPeeringId)))
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
        /// The <c>NetworkPeering</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string NetworkPeeringId { get; }

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
                case ResourceNameType.ProjectLocationNetworkPeering: return s_projectLocationNetworkPeering.Expand(ProjectId, LocationId, NetworkPeeringId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as NetworkPeeringName);

        /// <inheritdoc/>
        public bool Equals(NetworkPeeringName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(NetworkPeeringName a, NetworkPeeringName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(NetworkPeeringName a, NetworkPeeringName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>NetworkPolicy</c> resource.</summary>
    public sealed partial class NetworkPolicyName : gax::IResourceName, sys::IEquatable<NetworkPolicyName>
    {
        /// <summary>The possible contents of <see cref="NetworkPolicyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/networkPolicies/{network_policy}</c>
            /// .
            /// </summary>
            ProjectLocationNetworkPolicy = 1,
        }

        private static gax::PathTemplate s_projectLocationNetworkPolicy = new gax::PathTemplate("projects/{project}/locations/{location}/networkPolicies/{network_policy}");

        /// <summary>Creates a <see cref="NetworkPolicyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="NetworkPolicyName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static NetworkPolicyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new NetworkPolicyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="NetworkPolicyName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/networkPolicies/{network_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkPolicyId">The <c>NetworkPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="NetworkPolicyName"/> constructed from the provided ids.</returns>
        public static NetworkPolicyName FromProjectLocationNetworkPolicy(string projectId, string locationId, string networkPolicyId) =>
            new NetworkPolicyName(ResourceNameType.ProjectLocationNetworkPolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), networkPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkPolicyId, nameof(networkPolicyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NetworkPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/networkPolicies/{network_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkPolicyId">The <c>NetworkPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NetworkPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/networkPolicies/{network_policy}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string networkPolicyId) =>
            FormatProjectLocationNetworkPolicy(projectId, locationId, networkPolicyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NetworkPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/networkPolicies/{network_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkPolicyId">The <c>NetworkPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NetworkPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/networkPolicies/{network_policy}</c>.
        /// </returns>
        public static string FormatProjectLocationNetworkPolicy(string projectId, string locationId, string networkPolicyId) =>
            s_projectLocationNetworkPolicy.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(networkPolicyId, nameof(networkPolicyId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NetworkPolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/networkPolicies/{network_policy}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="networkPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="NetworkPolicyName"/> if successful.</returns>
        public static NetworkPolicyName Parse(string networkPolicyName) => Parse(networkPolicyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NetworkPolicyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/networkPolicies/{network_policy}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="networkPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="NetworkPolicyName"/> if successful.</returns>
        public static NetworkPolicyName Parse(string networkPolicyName, bool allowUnparsed) =>
            TryParse(networkPolicyName, allowUnparsed, out NetworkPolicyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NetworkPolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/networkPolicies/{network_policy}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="networkPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NetworkPolicyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string networkPolicyName, out NetworkPolicyName result) =>
            TryParse(networkPolicyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NetworkPolicyName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/networkPolicies/{network_policy}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="networkPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NetworkPolicyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string networkPolicyName, bool allowUnparsed, out NetworkPolicyName result)
        {
            gax::GaxPreconditions.CheckNotNull(networkPolicyName, nameof(networkPolicyName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationNetworkPolicy.TryParseName(networkPolicyName, out resourceName))
            {
                result = FromProjectLocationNetworkPolicy(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(networkPolicyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private NetworkPolicyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string networkPolicyId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            NetworkPolicyId = networkPolicyId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="NetworkPolicyName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/networkPolicies/{network_policy}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkPolicyId">The <c>NetworkPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        public NetworkPolicyName(string projectId, string locationId, string networkPolicyId) : this(ResourceNameType.ProjectLocationNetworkPolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), networkPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkPolicyId, nameof(networkPolicyId)))
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
        /// The <c>NetworkPolicy</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string NetworkPolicyId { get; }

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
                case ResourceNameType.ProjectLocationNetworkPolicy: return s_projectLocationNetworkPolicy.Expand(ProjectId, LocationId, NetworkPolicyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as NetworkPolicyName);

        /// <inheritdoc/>
        public bool Equals(NetworkPolicyName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(NetworkPolicyName a, NetworkPolicyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(NetworkPolicyName a, NetworkPolicyName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ManagementDnsZoneBinding</c> resource.</summary>
    public sealed partial class ManagementDnsZoneBindingName : gax::IResourceName, sys::IEquatable<ManagementDnsZoneBindingName>
    {
        /// <summary>The possible contents of <see cref="ManagementDnsZoneBindingName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/privateClouds/{private_cloud}/managementDnsZoneBindings/{management_dns_zone_binding}</c>
            /// .
            /// </summary>
            ProjectLocationPrivateCloudManagementDnsZoneBinding = 1,
        }

        private static gax::PathTemplate s_projectLocationPrivateCloudManagementDnsZoneBinding = new gax::PathTemplate("projects/{project}/locations/{location}/privateClouds/{private_cloud}/managementDnsZoneBindings/{management_dns_zone_binding}");

        /// <summary>
        /// Creates a <see cref="ManagementDnsZoneBindingName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ManagementDnsZoneBindingName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ManagementDnsZoneBindingName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ManagementDnsZoneBindingName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ManagementDnsZoneBindingName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/privateClouds/{private_cloud}/managementDnsZoneBindings/{management_dns_zone_binding}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="managementDnsZoneBindingId">
        /// The <c>ManagementDnsZoneBinding</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="ManagementDnsZoneBindingName"/> constructed from the provided ids.
        /// </returns>
        public static ManagementDnsZoneBindingName FromProjectLocationPrivateCloudManagementDnsZoneBinding(string projectId, string locationId, string privateCloudId, string managementDnsZoneBindingId) =>
            new ManagementDnsZoneBindingName(ResourceNameType.ProjectLocationPrivateCloudManagementDnsZoneBinding, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), privateCloudId: gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloudId, nameof(privateCloudId)), managementDnsZoneBindingId: gax::GaxPreconditions.CheckNotNullOrEmpty(managementDnsZoneBindingId, nameof(managementDnsZoneBindingId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ManagementDnsZoneBindingName"/> with
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/privateClouds/{private_cloud}/managementDnsZoneBindings/{management_dns_zone_binding}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="managementDnsZoneBindingId">
        /// The <c>ManagementDnsZoneBinding</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ManagementDnsZoneBindingName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/privateClouds/{private_cloud}/managementDnsZoneBindings/{management_dns_zone_binding}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string privateCloudId, string managementDnsZoneBindingId) =>
            FormatProjectLocationPrivateCloudManagementDnsZoneBinding(projectId, locationId, privateCloudId, managementDnsZoneBindingId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ManagementDnsZoneBindingName"/> with
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/privateClouds/{private_cloud}/managementDnsZoneBindings/{management_dns_zone_binding}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="managementDnsZoneBindingId">
        /// The <c>ManagementDnsZoneBinding</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ManagementDnsZoneBindingName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/privateClouds/{private_cloud}/managementDnsZoneBindings/{management_dns_zone_binding}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationPrivateCloudManagementDnsZoneBinding(string projectId, string locationId, string privateCloudId, string managementDnsZoneBindingId) =>
            s_projectLocationPrivateCloudManagementDnsZoneBinding.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloudId, nameof(privateCloudId)), gax::GaxPreconditions.CheckNotNullOrEmpty(managementDnsZoneBindingId, nameof(managementDnsZoneBindingId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ManagementDnsZoneBindingName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/privateClouds/{private_cloud}/managementDnsZoneBindings/{management_dns_zone_binding}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="managementDnsZoneBindingName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="ManagementDnsZoneBindingName"/> if successful.</returns>
        public static ManagementDnsZoneBindingName Parse(string managementDnsZoneBindingName) =>
            Parse(managementDnsZoneBindingName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ManagementDnsZoneBindingName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/privateClouds/{private_cloud}/managementDnsZoneBindings/{management_dns_zone_binding}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="managementDnsZoneBindingName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ManagementDnsZoneBindingName"/> if successful.</returns>
        public static ManagementDnsZoneBindingName Parse(string managementDnsZoneBindingName, bool allowUnparsed) =>
            TryParse(managementDnsZoneBindingName, allowUnparsed, out ManagementDnsZoneBindingName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ManagementDnsZoneBindingName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/privateClouds/{private_cloud}/managementDnsZoneBindings/{management_dns_zone_binding}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="managementDnsZoneBindingName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ManagementDnsZoneBindingName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string managementDnsZoneBindingName, out ManagementDnsZoneBindingName result) =>
            TryParse(managementDnsZoneBindingName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ManagementDnsZoneBindingName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/privateClouds/{private_cloud}/managementDnsZoneBindings/{management_dns_zone_binding}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="managementDnsZoneBindingName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ManagementDnsZoneBindingName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string managementDnsZoneBindingName, bool allowUnparsed, out ManagementDnsZoneBindingName result)
        {
            gax::GaxPreconditions.CheckNotNull(managementDnsZoneBindingName, nameof(managementDnsZoneBindingName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationPrivateCloudManagementDnsZoneBinding.TryParseName(managementDnsZoneBindingName, out resourceName))
            {
                result = FromProjectLocationPrivateCloudManagementDnsZoneBinding(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(managementDnsZoneBindingName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ManagementDnsZoneBindingName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string managementDnsZoneBindingId = null, string privateCloudId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ManagementDnsZoneBindingId = managementDnsZoneBindingId;
            PrivateCloudId = privateCloudId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ManagementDnsZoneBindingName"/> class from the component parts of
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/privateClouds/{private_cloud}/managementDnsZoneBindings/{management_dns_zone_binding}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateCloudId">The <c>PrivateCloud</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="managementDnsZoneBindingId">
        /// The <c>ManagementDnsZoneBinding</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public ManagementDnsZoneBindingName(string projectId, string locationId, string privateCloudId, string managementDnsZoneBindingId) : this(ResourceNameType.ProjectLocationPrivateCloudManagementDnsZoneBinding, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), privateCloudId: gax::GaxPreconditions.CheckNotNullOrEmpty(privateCloudId, nameof(privateCloudId)), managementDnsZoneBindingId: gax::GaxPreconditions.CheckNotNullOrEmpty(managementDnsZoneBindingId, nameof(managementDnsZoneBindingId)))
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
        /// The <c>ManagementDnsZoneBinding</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string ManagementDnsZoneBindingId { get; }

        /// <summary>
        /// The <c>PrivateCloud</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string PrivateCloudId { get; }

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
                case ResourceNameType.ProjectLocationPrivateCloudManagementDnsZoneBinding: return s_projectLocationPrivateCloudManagementDnsZoneBinding.Expand(ProjectId, LocationId, PrivateCloudId, ManagementDnsZoneBindingId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ManagementDnsZoneBindingName);

        /// <inheritdoc/>
        public bool Equals(ManagementDnsZoneBindingName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ManagementDnsZoneBindingName a, ManagementDnsZoneBindingName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ManagementDnsZoneBindingName a, ManagementDnsZoneBindingName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>VmwareEngineNetwork</c> resource.</summary>
    public sealed partial class VmwareEngineNetworkName : gax::IResourceName, sys::IEquatable<VmwareEngineNetworkName>
    {
        /// <summary>The possible contents of <see cref="VmwareEngineNetworkName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/vmwareEngineNetworks/{vmware_engine_network}</c>.
            /// </summary>
            ProjectLocationVmwareEngineNetwork = 1,
        }

        private static gax::PathTemplate s_projectLocationVmwareEngineNetwork = new gax::PathTemplate("projects/{project}/locations/{location}/vmwareEngineNetworks/{vmware_engine_network}");

        /// <summary>Creates a <see cref="VmwareEngineNetworkName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="VmwareEngineNetworkName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static VmwareEngineNetworkName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new VmwareEngineNetworkName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="VmwareEngineNetworkName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/vmwareEngineNetworks/{vmware_engine_network}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="vmwareEngineNetworkId">
        /// The <c>VmwareEngineNetwork</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="VmwareEngineNetworkName"/> constructed from the provided ids.
        /// </returns>
        public static VmwareEngineNetworkName FromProjectLocationVmwareEngineNetwork(string projectId, string locationId, string vmwareEngineNetworkId) =>
            new VmwareEngineNetworkName(ResourceNameType.ProjectLocationVmwareEngineNetwork, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), vmwareEngineNetworkId: gax::GaxPreconditions.CheckNotNullOrEmpty(vmwareEngineNetworkId, nameof(vmwareEngineNetworkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="VmwareEngineNetworkName"/> with pattern
        /// <c>projects/{project}/locations/{location}/vmwareEngineNetworks/{vmware_engine_network}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="vmwareEngineNetworkId">
        /// The <c>VmwareEngineNetwork</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="VmwareEngineNetworkName"/> with pattern
        /// <c>projects/{project}/locations/{location}/vmwareEngineNetworks/{vmware_engine_network}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string vmwareEngineNetworkId) =>
            FormatProjectLocationVmwareEngineNetwork(projectId, locationId, vmwareEngineNetworkId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="VmwareEngineNetworkName"/> with pattern
        /// <c>projects/{project}/locations/{location}/vmwareEngineNetworks/{vmware_engine_network}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="vmwareEngineNetworkId">
        /// The <c>VmwareEngineNetwork</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="VmwareEngineNetworkName"/> with pattern
        /// <c>projects/{project}/locations/{location}/vmwareEngineNetworks/{vmware_engine_network}</c>.
        /// </returns>
        public static string FormatProjectLocationVmwareEngineNetwork(string projectId, string locationId, string vmwareEngineNetworkId) =>
            s_projectLocationVmwareEngineNetwork.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(vmwareEngineNetworkId, nameof(vmwareEngineNetworkId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="VmwareEngineNetworkName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/vmwareEngineNetworks/{vmware_engine_network}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="vmwareEngineNetworkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="VmwareEngineNetworkName"/> if successful.</returns>
        public static VmwareEngineNetworkName Parse(string vmwareEngineNetworkName) => Parse(vmwareEngineNetworkName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="VmwareEngineNetworkName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/vmwareEngineNetworks/{vmware_engine_network}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="vmwareEngineNetworkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="VmwareEngineNetworkName"/> if successful.</returns>
        public static VmwareEngineNetworkName Parse(string vmwareEngineNetworkName, bool allowUnparsed) =>
            TryParse(vmwareEngineNetworkName, allowUnparsed, out VmwareEngineNetworkName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="VmwareEngineNetworkName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/vmwareEngineNetworks/{vmware_engine_network}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="vmwareEngineNetworkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="VmwareEngineNetworkName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string vmwareEngineNetworkName, out VmwareEngineNetworkName result) =>
            TryParse(vmwareEngineNetworkName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="VmwareEngineNetworkName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/vmwareEngineNetworks/{vmware_engine_network}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="vmwareEngineNetworkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="VmwareEngineNetworkName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string vmwareEngineNetworkName, bool allowUnparsed, out VmwareEngineNetworkName result)
        {
            gax::GaxPreconditions.CheckNotNull(vmwareEngineNetworkName, nameof(vmwareEngineNetworkName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationVmwareEngineNetwork.TryParseName(vmwareEngineNetworkName, out resourceName))
            {
                result = FromProjectLocationVmwareEngineNetwork(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(vmwareEngineNetworkName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private VmwareEngineNetworkName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string vmwareEngineNetworkId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            VmwareEngineNetworkId = vmwareEngineNetworkId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="VmwareEngineNetworkName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/vmwareEngineNetworks/{vmware_engine_network}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="vmwareEngineNetworkId">
        /// The <c>VmwareEngineNetwork</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public VmwareEngineNetworkName(string projectId, string locationId, string vmwareEngineNetworkId) : this(ResourceNameType.ProjectLocationVmwareEngineNetwork, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), vmwareEngineNetworkId: gax::GaxPreconditions.CheckNotNullOrEmpty(vmwareEngineNetworkId, nameof(vmwareEngineNetworkId)))
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
        /// The <c>VmwareEngineNetwork</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string VmwareEngineNetworkId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationVmwareEngineNetwork: return s_projectLocationVmwareEngineNetwork.Expand(ProjectId, LocationId, VmwareEngineNetworkId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as VmwareEngineNetworkName);

        /// <inheritdoc/>
        public bool Equals(VmwareEngineNetworkName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(VmwareEngineNetworkName a, VmwareEngineNetworkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(VmwareEngineNetworkName a, VmwareEngineNetworkName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>PrivateConnection</c> resource.</summary>
    public sealed partial class PrivateConnectionName : gax::IResourceName, sys::IEquatable<PrivateConnectionName>
    {
        /// <summary>The possible contents of <see cref="PrivateConnectionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/privateConnections/{private_connection}</c>.
            /// </summary>
            ProjectLocationPrivateConnection = 1,
        }

        private static gax::PathTemplate s_projectLocationPrivateConnection = new gax::PathTemplate("projects/{project}/locations/{location}/privateConnections/{private_connection}");

        /// <summary>Creates a <see cref="PrivateConnectionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PrivateConnectionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PrivateConnectionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PrivateConnectionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PrivateConnectionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/privateConnections/{private_connection}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateConnectionId">The <c>PrivateConnection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PrivateConnectionName"/> constructed from the provided ids.</returns>
        public static PrivateConnectionName FromProjectLocationPrivateConnection(string projectId, string locationId, string privateConnectionId) =>
            new PrivateConnectionName(ResourceNameType.ProjectLocationPrivateConnection, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), privateConnectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(privateConnectionId, nameof(privateConnectionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PrivateConnectionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateConnections/{private_connection}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateConnectionId">The <c>PrivateConnection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PrivateConnectionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateConnections/{private_connection}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string privateConnectionId) =>
            FormatProjectLocationPrivateConnection(projectId, locationId, privateConnectionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PrivateConnectionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateConnections/{private_connection}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateConnectionId">The <c>PrivateConnection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PrivateConnectionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateConnections/{private_connection}</c>.
        /// </returns>
        public static string FormatProjectLocationPrivateConnection(string projectId, string locationId, string privateConnectionId) =>
            s_projectLocationPrivateConnection.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(privateConnectionId, nameof(privateConnectionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PrivateConnectionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateConnections/{private_connection}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="privateConnectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PrivateConnectionName"/> if successful.</returns>
        public static PrivateConnectionName Parse(string privateConnectionName) => Parse(privateConnectionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PrivateConnectionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateConnections/{private_connection}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="privateConnectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PrivateConnectionName"/> if successful.</returns>
        public static PrivateConnectionName Parse(string privateConnectionName, bool allowUnparsed) =>
            TryParse(privateConnectionName, allowUnparsed, out PrivateConnectionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PrivateConnectionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateConnections/{private_connection}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="privateConnectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PrivateConnectionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string privateConnectionName, out PrivateConnectionName result) =>
            TryParse(privateConnectionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PrivateConnectionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateConnections/{private_connection}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="privateConnectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PrivateConnectionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string privateConnectionName, bool allowUnparsed, out PrivateConnectionName result)
        {
            gax::GaxPreconditions.CheckNotNull(privateConnectionName, nameof(privateConnectionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationPrivateConnection.TryParseName(privateConnectionName, out resourceName))
            {
                result = FromProjectLocationPrivateConnection(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(privateConnectionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PrivateConnectionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string privateConnectionId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            PrivateConnectionId = privateConnectionId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PrivateConnectionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/privateConnections/{private_connection}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateConnectionId">The <c>PrivateConnection</c> ID. Must not be <c>null</c> or empty.</param>
        public PrivateConnectionName(string projectId, string locationId, string privateConnectionId) : this(ResourceNameType.ProjectLocationPrivateConnection, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), privateConnectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(privateConnectionId, nameof(privateConnectionId)))
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
        /// The <c>PrivateConnection</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string PrivateConnectionId { get; }

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
                case ResourceNameType.ProjectLocationPrivateConnection: return s_projectLocationPrivateConnection.Expand(ProjectId, LocationId, PrivateConnectionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PrivateConnectionName);

        /// <inheritdoc/>
        public bool Equals(PrivateConnectionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PrivateConnectionName a, PrivateConnectionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PrivateConnectionName a, PrivateConnectionName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>DnsBindPermission</c> resource.</summary>
    public sealed partial class DnsBindPermissionName : gax::IResourceName, sys::IEquatable<DnsBindPermissionName>
    {
        /// <summary>The possible contents of <see cref="DnsBindPermissionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/dnsBindPermission</c>.
            /// </summary>
            ProjectLocation = 1,
        }

        private static gax::PathTemplate s_projectLocation = new gax::PathTemplate("projects/{project}/locations/{location}/dnsBindPermission");

        /// <summary>Creates a <see cref="DnsBindPermissionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DnsBindPermissionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DnsBindPermissionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DnsBindPermissionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DnsBindPermissionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/dnsBindPermission</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DnsBindPermissionName"/> constructed from the provided ids.</returns>
        public static DnsBindPermissionName FromProjectLocation(string projectId, string locationId) =>
            new DnsBindPermissionName(ResourceNameType.ProjectLocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DnsBindPermissionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dnsBindPermission</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DnsBindPermissionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dnsBindPermission</c>.
        /// </returns>
        public static string Format(string projectId, string locationId) => FormatProjectLocation(projectId, locationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DnsBindPermissionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dnsBindPermission</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DnsBindPermissionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dnsBindPermission</c>.
        /// </returns>
        public static string FormatProjectLocation(string projectId, string locationId) =>
            s_projectLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DnsBindPermissionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/dnsBindPermission</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="dnsBindPermissionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DnsBindPermissionName"/> if successful.</returns>
        public static DnsBindPermissionName Parse(string dnsBindPermissionName) => Parse(dnsBindPermissionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DnsBindPermissionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/dnsBindPermission</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dnsBindPermissionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DnsBindPermissionName"/> if successful.</returns>
        public static DnsBindPermissionName Parse(string dnsBindPermissionName, bool allowUnparsed) =>
            TryParse(dnsBindPermissionName, allowUnparsed, out DnsBindPermissionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DnsBindPermissionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/dnsBindPermission</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="dnsBindPermissionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DnsBindPermissionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dnsBindPermissionName, out DnsBindPermissionName result) =>
            TryParse(dnsBindPermissionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DnsBindPermissionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/dnsBindPermission</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dnsBindPermissionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DnsBindPermissionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dnsBindPermissionName, bool allowUnparsed, out DnsBindPermissionName result)
        {
            gax::GaxPreconditions.CheckNotNull(dnsBindPermissionName, nameof(dnsBindPermissionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocation.TryParseName(dnsBindPermissionName, out resourceName))
            {
                result = FromProjectLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dnsBindPermissionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DnsBindPermissionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DnsBindPermissionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/dnsBindPermission</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        public DnsBindPermissionName(string projectId, string locationId) : this(ResourceNameType.ProjectLocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)))
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
        public override bool Equals(object obj) => Equals(obj as DnsBindPermissionName);

        /// <inheritdoc/>
        public bool Equals(DnsBindPermissionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DnsBindPermissionName a, DnsBindPermissionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DnsBindPermissionName a, DnsBindPermissionName b) => !(a == b);
    }

    public partial class NetworkConfig
    {
        /// <summary>
        /// <see cref="VmwareEngineNetworkName"/>-typed view over the <see cref="VmwareEngineNetwork"/> resource name
        /// property.
        /// </summary>
        public VmwareEngineNetworkName VmwareEngineNetworkAsVmwareEngineNetworkName
        {
            get => string.IsNullOrEmpty(VmwareEngineNetwork) ? null : VmwareEngineNetworkName.Parse(VmwareEngineNetwork, allowUnparsed: true);
            set => VmwareEngineNetwork = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="VmwareEngineNetworkName"/>-typed view over the <see cref="VmwareEngineNetworkCanonical"/>
        /// resource name property.
        /// </summary>
        public VmwareEngineNetworkName VmwareEngineNetworkCanonicalAsVmwareEngineNetworkName
        {
            get => string.IsNullOrEmpty(VmwareEngineNetworkCanonical) ? null : VmwareEngineNetworkName.Parse(VmwareEngineNetworkCanonical, allowUnparsed: true);
            set => VmwareEngineNetworkCanonical = value?.ToString() ?? "";
        }
    }

    public partial class StretchedClusterConfig
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="PreferredLocation"/> resource name property.
        /// </summary>
        public gagr::LocationName PreferredLocationAsLocationName
        {
            get => string.IsNullOrEmpty(PreferredLocation) ? null : gagr::LocationName.Parse(PreferredLocation, allowUnparsed: true);
            set => PreferredLocation = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="SecondaryLocation"/> resource name property.
        /// </summary>
        public gagr::LocationName SecondaryLocationAsLocationName
        {
            get => string.IsNullOrEmpty(SecondaryLocation) ? null : gagr::LocationName.Parse(SecondaryLocation, allowUnparsed: true);
            set => SecondaryLocation = value?.ToString() ?? "";
        }
    }

    public partial class PrivateCloud
    {
        /// <summary>
        /// <see cref="gcvv::PrivateCloudName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::PrivateCloudName PrivateCloudName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::PrivateCloudName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Cluster
    {
        /// <summary>
        /// <see cref="gcvv::ClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ClusterName ClusterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ClusterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Node
    {
        /// <summary>
        /// <see cref="gcvv::NodeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::NodeName NodeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::NodeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ExternalAddress
    {
        /// <summary>
        /// <see cref="gcvv::ExternalAddressName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ExternalAddressName ExternalAddressName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ExternalAddressName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Subnet
    {
        /// <summary>
        /// <see cref="gcvv::SubnetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::SubnetName SubnetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::SubnetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ExternalAccessRule
    {
        /// <summary>
        /// <see cref="gcvv::ExternalAccessRuleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ExternalAccessRuleName ExternalAccessRuleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ExternalAccessRuleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class IpRange
            {
                /// <summary>
                /// <see cref="ExternalAddressName"/>-typed view over the <see cref="ExternalAddress"/> resource name
                /// property.
                /// </summary>
                public ExternalAddressName ExternalAddressAsExternalAddressName
                {
                    get => string.IsNullOrEmpty(ExternalAddress) ? null : ExternalAddressName.Parse(ExternalAddress, allowUnparsed: true);
                    set => ExternalAddress = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class LoggingServer
    {
        /// <summary>
        /// <see cref="gcvv::LoggingServerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::LoggingServerName LoggingServerName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::LoggingServerName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class NodeType
    {
        /// <summary>
        /// <see cref="gcvv::NodeTypeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::NodeTypeName NodeTypeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::NodeTypeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class HcxActivationKey
    {
        /// <summary>
        /// <see cref="gcvv::HcxActivationKeyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::HcxActivationKeyName HcxActivationKeyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::HcxActivationKeyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DnsForwarding
    {
        /// <summary>
        /// <see cref="gcvv::DnsForwardingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::DnsForwardingName DnsForwardingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::DnsForwardingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class NetworkPeering
    {
        /// <summary>
        /// <see cref="gcvv::NetworkPeeringName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::NetworkPeeringName NetworkPeeringName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::NetworkPeeringName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="VmwareEngineNetworkName"/>-typed view over the <see cref="VmwareEngineNetwork"/> resource name
        /// property.
        /// </summary>
        public VmwareEngineNetworkName VmwareEngineNetworkAsVmwareEngineNetworkName
        {
            get => string.IsNullOrEmpty(VmwareEngineNetwork) ? null : VmwareEngineNetworkName.Parse(VmwareEngineNetwork, allowUnparsed: true);
            set => VmwareEngineNetwork = value?.ToString() ?? "";
        }
    }

    public partial class NetworkPolicy
    {
        /// <summary>
        /// <see cref="gcvv::NetworkPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::NetworkPolicyName NetworkPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::NetworkPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="VmwareEngineNetworkName"/>-typed view over the <see cref="VmwareEngineNetwork"/> resource name
        /// property.
        /// </summary>
        public VmwareEngineNetworkName VmwareEngineNetworkAsVmwareEngineNetworkName
        {
            get => string.IsNullOrEmpty(VmwareEngineNetwork) ? null : VmwareEngineNetworkName.Parse(VmwareEngineNetwork, allowUnparsed: true);
            set => VmwareEngineNetwork = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="VmwareEngineNetworkName"/>-typed view over the <see cref="VmwareEngineNetworkCanonical"/>
        /// resource name property.
        /// </summary>
        public VmwareEngineNetworkName VmwareEngineNetworkCanonicalAsVmwareEngineNetworkName
        {
            get => string.IsNullOrEmpty(VmwareEngineNetworkCanonical) ? null : VmwareEngineNetworkName.Parse(VmwareEngineNetworkCanonical, allowUnparsed: true);
            set => VmwareEngineNetworkCanonical = value?.ToString() ?? "";
        }
    }

    public partial class ManagementDnsZoneBinding
    {
        /// <summary>
        /// <see cref="gcvv::ManagementDnsZoneBindingName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcvv::ManagementDnsZoneBindingName ManagementDnsZoneBindingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ManagementDnsZoneBindingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="VpcNetwork"/> resource name property.
        /// </summary>
        public NetworkName VpcNetworkAsNetworkName
        {
            get => string.IsNullOrEmpty(VpcNetwork) ? null : NetworkName.Parse(VpcNetwork, allowUnparsed: true);
            set => VpcNetwork = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="VmwareEngineNetworkName"/>-typed view over the <see cref="VmwareEngineNetwork"/> resource name
        /// property.
        /// </summary>
        public VmwareEngineNetworkName VmwareEngineNetworkAsVmwareEngineNetworkName
        {
            get => string.IsNullOrEmpty(VmwareEngineNetwork) ? null : VmwareEngineNetworkName.Parse(VmwareEngineNetwork, allowUnparsed: true);
            set => VmwareEngineNetwork = value?.ToString() ?? "";
        }
    }

    public partial class VmwareEngineNetwork
    {
        /// <summary>
        /// <see cref="gcvv::VmwareEngineNetworkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::VmwareEngineNetworkName VmwareEngineNetworkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::VmwareEngineNetworkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class VpcNetwork
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
        }
    }

    public partial class PrivateConnection
    {
        /// <summary>
        /// <see cref="gcvv::PrivateConnectionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::PrivateConnectionName PrivateConnectionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::PrivateConnectionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="VmwareEngineNetworkName"/>-typed view over the <see cref="VmwareEngineNetwork"/> resource name
        /// property.
        /// </summary>
        public VmwareEngineNetworkName VmwareEngineNetworkAsVmwareEngineNetworkName
        {
            get => string.IsNullOrEmpty(VmwareEngineNetwork) ? null : VmwareEngineNetworkName.Parse(VmwareEngineNetwork, allowUnparsed: true);
            set => VmwareEngineNetwork = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="VmwareEngineNetworkName"/>-typed view over the <see cref="VmwareEngineNetworkCanonical"/>
        /// resource name property.
        /// </summary>
        public VmwareEngineNetworkName VmwareEngineNetworkCanonicalAsVmwareEngineNetworkName
        {
            get => string.IsNullOrEmpty(VmwareEngineNetworkCanonical) ? null : VmwareEngineNetworkName.Parse(VmwareEngineNetworkCanonical, allowUnparsed: true);
            set => VmwareEngineNetworkCanonical = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="ServiceNetwork"/> resource name property.
        /// </summary>
        public NetworkName ServiceNetworkAsNetworkName
        {
            get => string.IsNullOrEmpty(ServiceNetwork) ? null : NetworkName.Parse(ServiceNetwork, allowUnparsed: true);
            set => ServiceNetwork = value?.ToString() ?? "";
        }
    }

    public partial class DnsBindPermission
    {
        /// <summary>
        /// <see cref="gcvv::DnsBindPermissionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::DnsBindPermissionName DnsBindPermissionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::DnsBindPermissionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
