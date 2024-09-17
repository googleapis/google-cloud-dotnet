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
    /// <summary>Resource name for the <c>CloudVmCluster</c> resource.</summary>
    public sealed partial class CloudVmClusterName : gax::IResourceName, sys::IEquatable<CloudVmClusterName>
    {
        /// <summary>The possible contents of <see cref="CloudVmClusterName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}</c>.
            /// </summary>
            ProjectLocationCloudVmCluster = 1,
        }

        private static gax::PathTemplate s_projectLocationCloudVmCluster = new gax::PathTemplate("projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}");

        /// <summary>Creates a <see cref="CloudVmClusterName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CloudVmClusterName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CloudVmClusterName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CloudVmClusterName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CloudVmClusterName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cloudVmClusterId">The <c>CloudVmCluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CloudVmClusterName"/> constructed from the provided ids.</returns>
        public static CloudVmClusterName FromProjectLocationCloudVmCluster(string projectId, string locationId, string cloudVmClusterId) =>
            new CloudVmClusterName(ResourceNameType.ProjectLocationCloudVmCluster, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), cloudVmClusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(cloudVmClusterId, nameof(cloudVmClusterId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CloudVmClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cloudVmClusterId">The <c>CloudVmCluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CloudVmClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string cloudVmClusterId) =>
            FormatProjectLocationCloudVmCluster(projectId, locationId, cloudVmClusterId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CloudVmClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cloudVmClusterId">The <c>CloudVmCluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CloudVmClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}</c>.
        /// </returns>
        public static string FormatProjectLocationCloudVmCluster(string projectId, string locationId, string cloudVmClusterId) =>
            s_projectLocationCloudVmCluster.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(cloudVmClusterId, nameof(cloudVmClusterId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CloudVmClusterName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="cloudVmClusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CloudVmClusterName"/> if successful.</returns>
        public static CloudVmClusterName Parse(string cloudVmClusterName) => Parse(cloudVmClusterName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CloudVmClusterName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cloudVmClusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CloudVmClusterName"/> if successful.</returns>
        public static CloudVmClusterName Parse(string cloudVmClusterName, bool allowUnparsed) =>
            TryParse(cloudVmClusterName, allowUnparsed, out CloudVmClusterName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CloudVmClusterName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="cloudVmClusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CloudVmClusterName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cloudVmClusterName, out CloudVmClusterName result) =>
            TryParse(cloudVmClusterName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CloudVmClusterName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cloudVmClusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CloudVmClusterName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cloudVmClusterName, bool allowUnparsed, out CloudVmClusterName result)
        {
            gax::GaxPreconditions.CheckNotNull(cloudVmClusterName, nameof(cloudVmClusterName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationCloudVmCluster.TryParseName(cloudVmClusterName, out resourceName))
            {
                result = FromProjectLocationCloudVmCluster(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(cloudVmClusterName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CloudVmClusterName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string cloudVmClusterId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CloudVmClusterId = cloudVmClusterId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CloudVmClusterName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cloudVmClusterId">The <c>CloudVmCluster</c> ID. Must not be <c>null</c> or empty.</param>
        public CloudVmClusterName(string projectId, string locationId, string cloudVmClusterId) : this(ResourceNameType.ProjectLocationCloudVmCluster, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), cloudVmClusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(cloudVmClusterId, nameof(cloudVmClusterId)))
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
                case ResourceNameType.ProjectLocationCloudVmCluster: return s_projectLocationCloudVmCluster.Expand(ProjectId, LocationId, CloudVmClusterId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CloudVmClusterName);

        /// <inheritdoc/>
        public bool Equals(CloudVmClusterName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CloudVmClusterName a, CloudVmClusterName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CloudVmClusterName a, CloudVmClusterName b) => !(a == b);
    }

    public partial class CloudVmCluster
    {
        /// <summary>
        /// <see cref="gcov::CloudVmClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::CloudVmClusterName CloudVmClusterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::CloudVmClusterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CloudExadataInfrastructureName"/>-typed view over the <see cref="ExadataInfrastructure"/>
        /// resource name property.
        /// </summary>
        public CloudExadataInfrastructureName ExadataInfrastructureAsCloudExadataInfrastructureName
        {
            get => string.IsNullOrEmpty(ExadataInfrastructure) ? null : CloudExadataInfrastructureName.Parse(ExadataInfrastructure, allowUnparsed: true);
            set => ExadataInfrastructure = value?.ToString() ?? "";
        }

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
