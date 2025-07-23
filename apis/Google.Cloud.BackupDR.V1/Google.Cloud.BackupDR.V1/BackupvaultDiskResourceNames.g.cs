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
using sys = System;

namespace Google.Cloud.BackupDR.V1
{
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

    public partial class DiskRestoreProperties
    {
        /// <summary>
        /// <see cref="StoragePoolName"/>-typed view over the <see cref="StoragePool"/> resource name property.
        /// </summary>
        public StoragePoolName StoragePoolAsStoragePoolName
        {
            get => string.IsNullOrEmpty(StoragePool) ? null : StoragePoolName.Parse(StoragePool, allowUnparsed: true);
            set => StoragePool = value?.ToString() ?? "";
        }
    }
}
