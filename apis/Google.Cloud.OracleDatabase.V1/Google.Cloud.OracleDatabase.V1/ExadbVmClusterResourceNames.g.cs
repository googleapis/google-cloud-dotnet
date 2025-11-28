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
using gcov = Google.Cloud.OracleDatabase.V1;
using sys = System;

namespace Google.Cloud.OracleDatabase.V1
{
    /// <summary>Resource name for the <c>ExadbVmCluster</c> resource.</summary>
    public sealed partial class ExadbVmClusterName : gax::IResourceName, sys::IEquatable<ExadbVmClusterName>
    {
        /// <summary>The possible contents of <see cref="ExadbVmClusterName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}</c>.
            /// </summary>
            ProjectLocationExadbVmCluster = 1,
        }

        private static gax::PathTemplate s_projectLocationExadbVmCluster = new gax::PathTemplate("projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}");

        /// <summary>Creates a <see cref="ExadbVmClusterName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ExadbVmClusterName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ExadbVmClusterName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ExadbVmClusterName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ExadbVmClusterName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exadbVmClusterId">The <c>ExadbVmCluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ExadbVmClusterName"/> constructed from the provided ids.</returns>
        public static ExadbVmClusterName FromProjectLocationExadbVmCluster(string projectId, string locationId, string exadbVmClusterId) =>
            new ExadbVmClusterName(ResourceNameType.ProjectLocationExadbVmCluster, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), exadbVmClusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(exadbVmClusterId, nameof(exadbVmClusterId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExadbVmClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exadbVmClusterId">The <c>ExadbVmCluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ExadbVmClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string exadbVmClusterId) =>
            FormatProjectLocationExadbVmCluster(projectId, locationId, exadbVmClusterId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExadbVmClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exadbVmClusterId">The <c>ExadbVmCluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ExadbVmClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}</c>.
        /// </returns>
        public static string FormatProjectLocationExadbVmCluster(string projectId, string locationId, string exadbVmClusterId) =>
            s_projectLocationExadbVmCluster.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(exadbVmClusterId, nameof(exadbVmClusterId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ExadbVmClusterName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="exadbVmClusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ExadbVmClusterName"/> if successful.</returns>
        public static ExadbVmClusterName Parse(string exadbVmClusterName) => Parse(exadbVmClusterName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ExadbVmClusterName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="exadbVmClusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ExadbVmClusterName"/> if successful.</returns>
        public static ExadbVmClusterName Parse(string exadbVmClusterName, bool allowUnparsed) =>
            TryParse(exadbVmClusterName, allowUnparsed, out ExadbVmClusterName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExadbVmClusterName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="exadbVmClusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExadbVmClusterName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string exadbVmClusterName, out ExadbVmClusterName result) =>
            TryParse(exadbVmClusterName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExadbVmClusterName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="exadbVmClusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExadbVmClusterName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string exadbVmClusterName, bool allowUnparsed, out ExadbVmClusterName result)
        {
            gax::GaxPreconditions.CheckNotNull(exadbVmClusterName, nameof(exadbVmClusterName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationExadbVmCluster.TryParseName(exadbVmClusterName, out resourceName))
            {
                result = FromProjectLocationExadbVmCluster(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(exadbVmClusterName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ExadbVmClusterName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string exadbVmClusterId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ExadbVmClusterId = exadbVmClusterId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ExadbVmClusterName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exadbVmClusterId">The <c>ExadbVmCluster</c> ID. Must not be <c>null</c> or empty.</param>
        public ExadbVmClusterName(string projectId, string locationId, string exadbVmClusterId) : this(ResourceNameType.ProjectLocationExadbVmCluster, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), exadbVmClusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(exadbVmClusterId, nameof(exadbVmClusterId)))
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
        /// The <c>ExadbVmCluster</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ExadbVmClusterId { get; }

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
                case ResourceNameType.ProjectLocationExadbVmCluster: return s_projectLocationExadbVmCluster.Expand(ProjectId, LocationId, ExadbVmClusterId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ExadbVmClusterName);

        /// <inheritdoc/>
        public bool Equals(ExadbVmClusterName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ExadbVmClusterName a, ExadbVmClusterName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ExadbVmClusterName a, ExadbVmClusterName b) => !(a == b);
    }

    public partial class ExadbVmCluster
    {
        /// <summary>
        /// <see cref="gcov::ExadbVmClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::ExadbVmClusterName ExadbVmClusterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::ExadbVmClusterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="OdbNetworkName"/>-typed view over the <see cref="OdbNetwork"/> resource name property.
        /// </summary>
        public OdbNetworkName OdbNetworkAsOdbNetworkName
        {
            get => string.IsNullOrEmpty(OdbNetwork) ? null : OdbNetworkName.Parse(OdbNetwork, allowUnparsed: true);
            set => OdbNetwork = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="OdbSubnetName"/>-typed view over the <see cref="OdbSubnet"/> resource name property.
        /// </summary>
        public OdbSubnetName OdbSubnetAsOdbSubnetName
        {
            get => string.IsNullOrEmpty(OdbSubnet) ? null : OdbSubnetName.Parse(OdbSubnet, allowUnparsed: true);
            set => OdbSubnet = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="OdbSubnetName"/>-typed view over the <see cref="BackupOdbSubnet"/> resource name property.
        /// </summary>
        public OdbSubnetName BackupOdbSubnetAsOdbSubnetName
        {
            get => string.IsNullOrEmpty(BackupOdbSubnet) ? null : OdbSubnetName.Parse(BackupOdbSubnet, allowUnparsed: true);
            set => BackupOdbSubnet = value?.ToString() ?? "";
        }
    }

    public partial class ExadbVmClusterProperties
    {
        /// <summary>
        /// <see cref="ExascaleDbStorageVaultName"/>-typed view over the <see cref="ExascaleDbStorageVault"/> resource
        /// name property.
        /// </summary>
        public ExascaleDbStorageVaultName ExascaleDbStorageVaultAsExascaleDbStorageVaultName
        {
            get => string.IsNullOrEmpty(ExascaleDbStorageVault) ? null : ExascaleDbStorageVaultName.Parse(ExascaleDbStorageVault, allowUnparsed: true);
            set => ExascaleDbStorageVault = value?.ToString() ?? "";
        }
    }
}
