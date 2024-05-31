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
using gcnv = Google.Cloud.NetApp.V1;
using sys = System;

namespace Google.Cloud.NetApp.V1
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
            /// A resource name with pattern <c>projects/{project}/locations/{location}/storagePools/{storage_pool}</c>.
            /// </summary>
            ProjectLocationStoragePool = 1,
        }

        private static gax::PathTemplate s_projectLocationStoragePool = new gax::PathTemplate("projects/{project}/locations/{location}/storagePools/{storage_pool}");

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
        /// <c>projects/{project}/locations/{location}/storagePools/{storage_pool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="storagePoolId">The <c>StoragePool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="StoragePoolName"/> constructed from the provided ids.</returns>
        public static StoragePoolName FromProjectLocationStoragePool(string projectId, string locationId, string storagePoolId) =>
            new StoragePoolName(ResourceNameType.ProjectLocationStoragePool, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), storagePoolId: gax::GaxPreconditions.CheckNotNullOrEmpty(storagePoolId, nameof(storagePoolId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="StoragePoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/storagePools/{storage_pool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="storagePoolId">The <c>StoragePool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="StoragePoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/storagePools/{storage_pool}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string storagePoolId) =>
            FormatProjectLocationStoragePool(projectId, locationId, storagePoolId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="StoragePoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/storagePools/{storage_pool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="storagePoolId">The <c>StoragePool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="StoragePoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/storagePools/{storage_pool}</c>.
        /// </returns>
        public static string FormatProjectLocationStoragePool(string projectId, string locationId, string storagePoolId) =>
            s_projectLocationStoragePool.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(storagePoolId, nameof(storagePoolId)));

        /// <summary>Parses the given resource name string into a new <see cref="StoragePoolName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/storagePools/{storage_pool}</c></description>
        /// </item>
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
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/storagePools/{storage_pool}</c></description>
        /// </item>
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
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/storagePools/{storage_pool}</c></description>
        /// </item>
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
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/storagePools/{storage_pool}</c></description>
        /// </item>
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
            if (s_projectLocationStoragePool.TryParseName(storagePoolName, out resourceName))
            {
                result = FromProjectLocationStoragePool(resourceName[0], resourceName[1], resourceName[2]);
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

        private StoragePoolName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string storagePoolId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            StoragePoolId = storagePoolId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="StoragePoolName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/storagePools/{storage_pool}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="storagePoolId">The <c>StoragePool</c> ID. Must not be <c>null</c> or empty.</param>
        public StoragePoolName(string projectId, string locationId, string storagePoolId) : this(ResourceNameType.ProjectLocationStoragePool, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), storagePoolId: gax::GaxPreconditions.CheckNotNullOrEmpty(storagePoolId, nameof(storagePoolId)))
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
        /// The <c>StoragePool</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string StoragePoolId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationStoragePool: return s_projectLocationStoragePool.Expand(ProjectId, LocationId, StoragePoolId);
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

    public partial class GetStoragePoolRequest
    {
        /// <summary>
        /// <see cref="gcnv::StoragePoolName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::StoragePoolName StoragePoolName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::StoragePoolName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListStoragePoolsRequest
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

    public partial class CreateStoragePoolRequest
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

    public partial class DeleteStoragePoolRequest
    {
        /// <summary>
        /// <see cref="gcnv::StoragePoolName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::StoragePoolName StoragePoolName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::StoragePoolName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class StoragePool
    {
        /// <summary>
        /// <see cref="gcnv::StoragePoolName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::StoragePoolName StoragePoolName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::StoragePoolName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Network"/> resource name property.
        /// </summary>
        public NetworkName NetworkAsNetworkName
        {
            get => string.IsNullOrEmpty(Network) ? null : NetworkName.Parse(Network, allowUnparsed: true);
            set => Network = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ActiveDirectoryName"/>-typed view over the <see cref="ActiveDirectory"/> resource name property.
        /// </summary>
        public ActiveDirectoryName ActiveDirectoryAsActiveDirectoryName
        {
            get => string.IsNullOrEmpty(ActiveDirectory) ? null : ActiveDirectoryName.Parse(ActiveDirectory, allowUnparsed: true);
            set => ActiveDirectory = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="KmsConfigName"/>-typed view over the <see cref="KmsConfig"/> resource name property.
        /// </summary>
        public KmsConfigName KmsConfigAsKmsConfigName
        {
            get => string.IsNullOrEmpty(KmsConfig) ? null : KmsConfigName.Parse(KmsConfig, allowUnparsed: true);
            set => KmsConfig = value?.ToString() ?? "";
        }
    }
}
