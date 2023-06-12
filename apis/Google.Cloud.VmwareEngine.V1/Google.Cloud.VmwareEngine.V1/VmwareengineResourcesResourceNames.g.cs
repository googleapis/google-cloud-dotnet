// Copyright 2023 Google LLC
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

        /// <inheritdoc/>
        public static bool operator ==(PrivateCloudName a, PrivateCloudName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public static bool operator ==(ClusterName a, ClusterName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ClusterName a, ClusterName b) => !(a == b);
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

        /// <inheritdoc/>
        public static bool operator ==(SubnetName a, SubnetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(SubnetName a, SubnetName b) => !(a == b);
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

        /// <inheritdoc/>
        public static bool operator ==(NodeTypeName a, NodeTypeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public static bool operator ==(HcxActivationKeyName a, HcxActivationKeyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(HcxActivationKeyName a, HcxActivationKeyName b) => !(a == b);
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

        /// <inheritdoc/>
        public static bool operator ==(NetworkPolicyName a, NetworkPolicyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(NetworkPolicyName a, NetworkPolicyName b) => !(a == b);
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

        /// <inheritdoc/>
        public static bool operator ==(VmwareEngineNetworkName a, VmwareEngineNetworkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public static bool operator ==(PrivateConnectionName a, PrivateConnectionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(PrivateConnectionName a, PrivateConnectionName b) => !(a == b);
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
}
