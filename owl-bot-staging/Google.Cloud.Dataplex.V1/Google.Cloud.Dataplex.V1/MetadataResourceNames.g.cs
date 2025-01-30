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
using gcdv = Google.Cloud.Dataplex.V1;
using sys = System;

namespace Google.Cloud.Dataplex.V1
{
    /// <summary>Resource name for the <c>Entity</c> resource.</summary>
    public sealed partial class EntityName : gax::IResourceName, sys::IEquatable<EntityName>
    {
        /// <summary>The possible contents of <see cref="EntityName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/entities/{entity}</c>.
            /// </summary>
            ProjectLocationLakeZoneEntity = 1,
        }

        private static gax::PathTemplate s_projectLocationLakeZoneEntity = new gax::PathTemplate("projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/entities/{entity}");

        /// <summary>Creates a <see cref="EntityName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EntityName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EntityName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EntityName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EntityName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/entities/{entity}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityId">The <c>Entity</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EntityName"/> constructed from the provided ids.</returns>
        public static EntityName FromProjectLocationLakeZoneEntity(string projectId, string locationId, string lakeId, string zoneId, string entityId) =>
            new EntityName(ResourceNameType.ProjectLocationLakeZoneEntity, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), lakeId: gax::GaxPreconditions.CheckNotNullOrEmpty(lakeId, nameof(lakeId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), entityId: gax::GaxPreconditions.CheckNotNullOrEmpty(entityId, nameof(entityId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EntityName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/entities/{entity}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityId">The <c>Entity</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EntityName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/entities/{entity}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string lakeId, string zoneId, string entityId) =>
            FormatProjectLocationLakeZoneEntity(projectId, locationId, lakeId, zoneId, entityId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EntityName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/entities/{entity}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityId">The <c>Entity</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EntityName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/entities/{entity}</c>.
        /// </returns>
        public static string FormatProjectLocationLakeZoneEntity(string projectId, string locationId, string lakeId, string zoneId, string entityId) =>
            s_projectLocationLakeZoneEntity.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(lakeId, nameof(lakeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), gax::GaxPreconditions.CheckNotNullOrEmpty(entityId, nameof(entityId)));

        /// <summary>Parses the given resource name string into a new <see cref="EntityName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/entities/{entity}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="entityName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EntityName"/> if successful.</returns>
        public static EntityName Parse(string entityName) => Parse(entityName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EntityName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/entities/{entity}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="entityName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EntityName"/> if successful.</returns>
        public static EntityName Parse(string entityName, bool allowUnparsed) =>
            TryParse(entityName, allowUnparsed, out EntityName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EntityName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/entities/{entity}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="entityName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EntityName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string entityName, out EntityName result) => TryParse(entityName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EntityName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/entities/{entity}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="entityName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EntityName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string entityName, bool allowUnparsed, out EntityName result)
        {
            gax::GaxPreconditions.CheckNotNull(entityName, nameof(entityName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationLakeZoneEntity.TryParseName(entityName, out resourceName))
            {
                result = FromProjectLocationLakeZoneEntity(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(entityName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EntityName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string entityId = null, string lakeId = null, string locationId = null, string projectId = null, string zoneId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EntityId = entityId;
            LakeId = lakeId;
            LocationId = locationId;
            ProjectId = projectId;
            ZoneId = zoneId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EntityName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/entities/{entity}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityId">The <c>Entity</c> ID. Must not be <c>null</c> or empty.</param>
        public EntityName(string projectId, string locationId, string lakeId, string zoneId, string entityId) : this(ResourceNameType.ProjectLocationLakeZoneEntity, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), lakeId: gax::GaxPreconditions.CheckNotNullOrEmpty(lakeId, nameof(lakeId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), entityId: gax::GaxPreconditions.CheckNotNullOrEmpty(entityId, nameof(entityId)))
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
        /// The <c>Entity</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string EntityId { get; }

        /// <summary>
        /// The <c>Lake</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LakeId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

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
                case ResourceNameType.ProjectLocationLakeZoneEntity: return s_projectLocationLakeZoneEntity.Expand(ProjectId, LocationId, LakeId, ZoneId, EntityId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EntityName);

        /// <inheritdoc/>
        public bool Equals(EntityName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EntityName a, EntityName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EntityName a, EntityName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Partition</c> resource.</summary>
    public sealed partial class PartitionName : gax::IResourceName, sys::IEquatable<PartitionName>
    {
        /// <summary>The possible contents of <see cref="PartitionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/entities/{entity}/partitions/{partition}</c>
            /// .
            /// </summary>
            ProjectLocationLakeZoneEntityPartition = 1,
        }

        private static gax::PathTemplate s_projectLocationLakeZoneEntityPartition = new gax::PathTemplate("projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/entities/{entity}/partitions/{partition}");

        /// <summary>Creates a <see cref="PartitionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PartitionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PartitionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PartitionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PartitionName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/entities/{entity}/partitions/{partition}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityId">The <c>Entity</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="partitionId">The <c>Partition</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PartitionName"/> constructed from the provided ids.</returns>
        public static PartitionName FromProjectLocationLakeZoneEntityPartition(string projectId, string locationId, string lakeId, string zoneId, string entityId, string partitionId) =>
            new PartitionName(ResourceNameType.ProjectLocationLakeZoneEntityPartition, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), lakeId: gax::GaxPreconditions.CheckNotNullOrEmpty(lakeId, nameof(lakeId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), entityId: gax::GaxPreconditions.CheckNotNullOrEmpty(entityId, nameof(entityId)), partitionId: gax::GaxPreconditions.CheckNotNullOrEmpty(partitionId, nameof(partitionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PartitionName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/entities/{entity}/partitions/{partition}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityId">The <c>Entity</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="partitionId">The <c>Partition</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PartitionName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/entities/{entity}/partitions/{partition}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string lakeId, string zoneId, string entityId, string partitionId) =>
            FormatProjectLocationLakeZoneEntityPartition(projectId, locationId, lakeId, zoneId, entityId, partitionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PartitionName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/entities/{entity}/partitions/{partition}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityId">The <c>Entity</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="partitionId">The <c>Partition</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PartitionName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/entities/{entity}/partitions/{partition}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationLakeZoneEntityPartition(string projectId, string locationId, string lakeId, string zoneId, string entityId, string partitionId) =>
            s_projectLocationLakeZoneEntityPartition.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(lakeId, nameof(lakeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), gax::GaxPreconditions.CheckNotNullOrEmpty(entityId, nameof(entityId)), gax::GaxPreconditions.CheckNotNullOrEmpty(partitionId, nameof(partitionId)));

        /// <summary>Parses the given resource name string into a new <see cref="PartitionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/entities/{entity}/partitions/{partition}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="partitionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PartitionName"/> if successful.</returns>
        public static PartitionName Parse(string partitionName) => Parse(partitionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PartitionName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/entities/{entity}/partitions/{partition}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="partitionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PartitionName"/> if successful.</returns>
        public static PartitionName Parse(string partitionName, bool allowUnparsed) =>
            TryParse(partitionName, allowUnparsed, out PartitionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PartitionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/entities/{entity}/partitions/{partition}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="partitionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PartitionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string partitionName, out PartitionName result) => TryParse(partitionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PartitionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/entities/{entity}/partitions/{partition}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="partitionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PartitionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string partitionName, bool allowUnparsed, out PartitionName result)
        {
            gax::GaxPreconditions.CheckNotNull(partitionName, nameof(partitionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationLakeZoneEntityPartition.TryParseName(partitionName, out resourceName))
            {
                result = FromProjectLocationLakeZoneEntityPartition(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4], resourceName[5]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(partitionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PartitionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string entityId = null, string lakeId = null, string locationId = null, string partitionId = null, string projectId = null, string zoneId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EntityId = entityId;
            LakeId = lakeId;
            LocationId = locationId;
            PartitionId = partitionId;
            ProjectId = projectId;
            ZoneId = zoneId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PartitionName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/entities/{entity}/partitions/{partition}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityId">The <c>Entity</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="partitionId">The <c>Partition</c> ID. Must not be <c>null</c> or empty.</param>
        public PartitionName(string projectId, string locationId, string lakeId, string zoneId, string entityId, string partitionId) : this(ResourceNameType.ProjectLocationLakeZoneEntityPartition, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), lakeId: gax::GaxPreconditions.CheckNotNullOrEmpty(lakeId, nameof(lakeId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), entityId: gax::GaxPreconditions.CheckNotNullOrEmpty(entityId, nameof(entityId)), partitionId: gax::GaxPreconditions.CheckNotNullOrEmpty(partitionId, nameof(partitionId)))
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
        /// The <c>Entity</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string EntityId { get; }

        /// <summary>
        /// The <c>Lake</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LakeId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Partition</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PartitionId { get; }

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
                case ResourceNameType.ProjectLocationLakeZoneEntityPartition: return s_projectLocationLakeZoneEntityPartition.Expand(ProjectId, LocationId, LakeId, ZoneId, EntityId, PartitionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PartitionName);

        /// <inheritdoc/>
        public bool Equals(PartitionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PartitionName a, PartitionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PartitionName a, PartitionName b) => !(a == b);
    }

    public partial class CreateEntityRequest
    {
        /// <summary><see cref="ZoneName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ZoneName ParentAsZoneName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ZoneName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteEntityRequest
    {
        /// <summary>
        /// <see cref="gcdv::EntityName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::EntityName EntityName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::EntityName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListEntitiesRequest
    {
        /// <summary><see cref="ZoneName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ZoneName ParentAsZoneName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ZoneName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetEntityRequest
    {
        /// <summary>
        /// <see cref="gcdv::EntityName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::EntityName EntityName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::EntityName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListPartitionsRequest
    {
        /// <summary><see cref="EntityName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public EntityName ParentAsEntityName
        {
            get => string.IsNullOrEmpty(Parent) ? null : EntityName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreatePartitionRequest
    {
        /// <summary><see cref="EntityName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public EntityName ParentAsEntityName
        {
            get => string.IsNullOrEmpty(Parent) ? null : EntityName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeletePartitionRequest
    {
        /// <summary>
        /// <see cref="gcdv::PartitionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::PartitionName PartitionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::PartitionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetPartitionRequest
    {
        /// <summary>
        /// <see cref="gcdv::PartitionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::PartitionName PartitionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::PartitionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Entity
    {
        /// <summary>
        /// <see cref="gcdv::EntityName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::EntityName EntityName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::EntityName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Partition
    {
        /// <summary>
        /// <see cref="gcdv::PartitionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::PartitionName PartitionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::PartitionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
