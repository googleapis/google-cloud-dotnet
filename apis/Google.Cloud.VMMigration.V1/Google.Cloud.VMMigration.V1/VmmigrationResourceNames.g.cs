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
using gcvv = Google.Cloud.VMMigration.V1;
using sys = System;

namespace Google.Cloud.VMMigration.V1
{
    /// <summary>Resource name for the <c>ReplicationCycle</c> resource.</summary>
    public sealed partial class ReplicationCycleName : gax::IResourceName, sys::IEquatable<ReplicationCycleName>
    {
        /// <summary>The possible contents of <see cref="ReplicationCycleName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/replicationCycles/{replication_cycle}</c>
            /// .
            /// </summary>
            ProjectLocationSourceMigratingVmReplicationCycle = 1,
        }

        private static gax::PathTemplate s_projectLocationSourceMigratingVmReplicationCycle = new gax::PathTemplate("projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/replicationCycles/{replication_cycle}");

        /// <summary>Creates a <see cref="ReplicationCycleName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ReplicationCycleName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ReplicationCycleName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ReplicationCycleName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ReplicationCycleName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/replicationCycles/{replication_cycle}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="migratingVmId">The <c>MigratingVm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="replicationCycleId">The <c>ReplicationCycle</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ReplicationCycleName"/> constructed from the provided ids.</returns>
        public static ReplicationCycleName FromProjectLocationSourceMigratingVmReplicationCycle(string projectId, string locationId, string sourceId, string migratingVmId, string replicationCycleId) =>
            new ReplicationCycleName(ResourceNameType.ProjectLocationSourceMigratingVmReplicationCycle, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), migratingVmId: gax::GaxPreconditions.CheckNotNullOrEmpty(migratingVmId, nameof(migratingVmId)), replicationCycleId: gax::GaxPreconditions.CheckNotNullOrEmpty(replicationCycleId, nameof(replicationCycleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReplicationCycleName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/replicationCycles/{replication_cycle}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="migratingVmId">The <c>MigratingVm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="replicationCycleId">The <c>ReplicationCycle</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReplicationCycleName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/replicationCycles/{replication_cycle}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string sourceId, string migratingVmId, string replicationCycleId) =>
            FormatProjectLocationSourceMigratingVmReplicationCycle(projectId, locationId, sourceId, migratingVmId, replicationCycleId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReplicationCycleName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/replicationCycles/{replication_cycle}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="migratingVmId">The <c>MigratingVm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="replicationCycleId">The <c>ReplicationCycle</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReplicationCycleName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/replicationCycles/{replication_cycle}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationSourceMigratingVmReplicationCycle(string projectId, string locationId, string sourceId, string migratingVmId, string replicationCycleId) =>
            s_projectLocationSourceMigratingVmReplicationCycle.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(migratingVmId, nameof(migratingVmId)), gax::GaxPreconditions.CheckNotNullOrEmpty(replicationCycleId, nameof(replicationCycleId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ReplicationCycleName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/replicationCycles/{replication_cycle}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="replicationCycleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ReplicationCycleName"/> if successful.</returns>
        public static ReplicationCycleName Parse(string replicationCycleName) => Parse(replicationCycleName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ReplicationCycleName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/replicationCycles/{replication_cycle}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="replicationCycleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ReplicationCycleName"/> if successful.</returns>
        public static ReplicationCycleName Parse(string replicationCycleName, bool allowUnparsed) =>
            TryParse(replicationCycleName, allowUnparsed, out ReplicationCycleName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReplicationCycleName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/replicationCycles/{replication_cycle}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="replicationCycleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReplicationCycleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string replicationCycleName, out ReplicationCycleName result) =>
            TryParse(replicationCycleName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReplicationCycleName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/replicationCycles/{replication_cycle}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="replicationCycleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReplicationCycleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string replicationCycleName, bool allowUnparsed, out ReplicationCycleName result)
        {
            gax::GaxPreconditions.CheckNotNull(replicationCycleName, nameof(replicationCycleName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSourceMigratingVmReplicationCycle.TryParseName(replicationCycleName, out resourceName))
            {
                result = FromProjectLocationSourceMigratingVmReplicationCycle(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(replicationCycleName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ReplicationCycleName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string migratingVmId = null, string projectId = null, string replicationCycleId = null, string sourceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            MigratingVmId = migratingVmId;
            ProjectId = projectId;
            ReplicationCycleId = replicationCycleId;
            SourceId = sourceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ReplicationCycleName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/replicationCycles/{replication_cycle}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="migratingVmId">The <c>MigratingVm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="replicationCycleId">The <c>ReplicationCycle</c> ID. Must not be <c>null</c> or empty.</param>
        public ReplicationCycleName(string projectId, string locationId, string sourceId, string migratingVmId, string replicationCycleId) : this(ResourceNameType.ProjectLocationSourceMigratingVmReplicationCycle, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), migratingVmId: gax::GaxPreconditions.CheckNotNullOrEmpty(migratingVmId, nameof(migratingVmId)), replicationCycleId: gax::GaxPreconditions.CheckNotNullOrEmpty(replicationCycleId, nameof(replicationCycleId)))
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
        /// The <c>MigratingVm</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string MigratingVmId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>ReplicationCycle</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ReplicationCycleId { get; }

        /// <summary>
        /// The <c>Source</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SourceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSourceMigratingVmReplicationCycle: return s_projectLocationSourceMigratingVmReplicationCycle.Expand(ProjectId, LocationId, SourceId, MigratingVmId, ReplicationCycleId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ReplicationCycleName);

        /// <inheritdoc/>
        public bool Equals(ReplicationCycleName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ReplicationCycleName a, ReplicationCycleName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ReplicationCycleName a, ReplicationCycleName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>MigratingVm</c> resource.</summary>
    public sealed partial class MigratingVmName : gax::IResourceName, sys::IEquatable<MigratingVmName>
    {
        /// <summary>The possible contents of <see cref="MigratingVmName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}</c>.
            /// </summary>
            ProjectLocationSourceMigratingVm = 1,
        }

        private static gax::PathTemplate s_projectLocationSourceMigratingVm = new gax::PathTemplate("projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}");

        /// <summary>Creates a <see cref="MigratingVmName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MigratingVmName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MigratingVmName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MigratingVmName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MigratingVmName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="migratingVmId">The <c>MigratingVm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MigratingVmName"/> constructed from the provided ids.</returns>
        public static MigratingVmName FromProjectLocationSourceMigratingVm(string projectId, string locationId, string sourceId, string migratingVmId) =>
            new MigratingVmName(ResourceNameType.ProjectLocationSourceMigratingVm, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), migratingVmId: gax::GaxPreconditions.CheckNotNullOrEmpty(migratingVmId, nameof(migratingVmId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MigratingVmName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="migratingVmId">The <c>MigratingVm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MigratingVmName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string sourceId, string migratingVmId) =>
            FormatProjectLocationSourceMigratingVm(projectId, locationId, sourceId, migratingVmId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MigratingVmName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="migratingVmId">The <c>MigratingVm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MigratingVmName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}</c>.
        /// </returns>
        public static string FormatProjectLocationSourceMigratingVm(string projectId, string locationId, string sourceId, string migratingVmId) =>
            s_projectLocationSourceMigratingVm.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(migratingVmId, nameof(migratingVmId)));

        /// <summary>Parses the given resource name string into a new <see cref="MigratingVmName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="migratingVmName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MigratingVmName"/> if successful.</returns>
        public static MigratingVmName Parse(string migratingVmName) => Parse(migratingVmName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MigratingVmName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="migratingVmName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MigratingVmName"/> if successful.</returns>
        public static MigratingVmName Parse(string migratingVmName, bool allowUnparsed) =>
            TryParse(migratingVmName, allowUnparsed, out MigratingVmName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MigratingVmName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="migratingVmName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MigratingVmName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string migratingVmName, out MigratingVmName result) =>
            TryParse(migratingVmName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MigratingVmName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="migratingVmName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MigratingVmName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string migratingVmName, bool allowUnparsed, out MigratingVmName result)
        {
            gax::GaxPreconditions.CheckNotNull(migratingVmName, nameof(migratingVmName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSourceMigratingVm.TryParseName(migratingVmName, out resourceName))
            {
                result = FromProjectLocationSourceMigratingVm(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(migratingVmName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MigratingVmName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string migratingVmId = null, string projectId = null, string sourceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            MigratingVmId = migratingVmId;
            ProjectId = projectId;
            SourceId = sourceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MigratingVmName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="migratingVmId">The <c>MigratingVm</c> ID. Must not be <c>null</c> or empty.</param>
        public MigratingVmName(string projectId, string locationId, string sourceId, string migratingVmId) : this(ResourceNameType.ProjectLocationSourceMigratingVm, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), migratingVmId: gax::GaxPreconditions.CheckNotNullOrEmpty(migratingVmId, nameof(migratingVmId)))
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
        /// The <c>MigratingVm</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string MigratingVmId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Source</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SourceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSourceMigratingVm: return s_projectLocationSourceMigratingVm.Expand(ProjectId, LocationId, SourceId, MigratingVmId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MigratingVmName);

        /// <inheritdoc/>
        public bool Equals(MigratingVmName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(MigratingVmName a, MigratingVmName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(MigratingVmName a, MigratingVmName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>CloneJob</c> resource.</summary>
    public sealed partial class CloneJobName : gax::IResourceName, sys::IEquatable<CloneJobName>
    {
        /// <summary>The possible contents of <see cref="CloneJobName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/cloneJobs/{clone_job}</c>
            /// .
            /// </summary>
            ProjectLocationSourceMigratingVmCloneJob = 1,
        }

        private static gax::PathTemplate s_projectLocationSourceMigratingVmCloneJob = new gax::PathTemplate("projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/cloneJobs/{clone_job}");

        /// <summary>Creates a <see cref="CloneJobName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CloneJobName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static CloneJobName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CloneJobName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CloneJobName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/cloneJobs/{clone_job}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="migratingVmId">The <c>MigratingVm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cloneJobId">The <c>CloneJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CloneJobName"/> constructed from the provided ids.</returns>
        public static CloneJobName FromProjectLocationSourceMigratingVmCloneJob(string projectId, string locationId, string sourceId, string migratingVmId, string cloneJobId) =>
            new CloneJobName(ResourceNameType.ProjectLocationSourceMigratingVmCloneJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), migratingVmId: gax::GaxPreconditions.CheckNotNullOrEmpty(migratingVmId, nameof(migratingVmId)), cloneJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(cloneJobId, nameof(cloneJobId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CloneJobName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/cloneJobs/{clone_job}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="migratingVmId">The <c>MigratingVm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cloneJobId">The <c>CloneJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CloneJobName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/cloneJobs/{clone_job}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string sourceId, string migratingVmId, string cloneJobId) =>
            FormatProjectLocationSourceMigratingVmCloneJob(projectId, locationId, sourceId, migratingVmId, cloneJobId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CloneJobName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/cloneJobs/{clone_job}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="migratingVmId">The <c>MigratingVm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cloneJobId">The <c>CloneJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CloneJobName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/cloneJobs/{clone_job}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationSourceMigratingVmCloneJob(string projectId, string locationId, string sourceId, string migratingVmId, string cloneJobId) =>
            s_projectLocationSourceMigratingVmCloneJob.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(migratingVmId, nameof(migratingVmId)), gax::GaxPreconditions.CheckNotNullOrEmpty(cloneJobId, nameof(cloneJobId)));

        /// <summary>Parses the given resource name string into a new <see cref="CloneJobName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/cloneJobs/{clone_job}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="cloneJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CloneJobName"/> if successful.</returns>
        public static CloneJobName Parse(string cloneJobName) => Parse(cloneJobName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CloneJobName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/cloneJobs/{clone_job}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cloneJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CloneJobName"/> if successful.</returns>
        public static CloneJobName Parse(string cloneJobName, bool allowUnparsed) =>
            TryParse(cloneJobName, allowUnparsed, out CloneJobName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CloneJobName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/cloneJobs/{clone_job}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="cloneJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CloneJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cloneJobName, out CloneJobName result) => TryParse(cloneJobName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CloneJobName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/cloneJobs/{clone_job}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cloneJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CloneJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cloneJobName, bool allowUnparsed, out CloneJobName result)
        {
            gax::GaxPreconditions.CheckNotNull(cloneJobName, nameof(cloneJobName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSourceMigratingVmCloneJob.TryParseName(cloneJobName, out resourceName))
            {
                result = FromProjectLocationSourceMigratingVmCloneJob(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(cloneJobName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CloneJobName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string cloneJobId = null, string locationId = null, string migratingVmId = null, string projectId = null, string sourceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CloneJobId = cloneJobId;
            LocationId = locationId;
            MigratingVmId = migratingVmId;
            ProjectId = projectId;
            SourceId = sourceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CloneJobName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/cloneJobs/{clone_job}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="migratingVmId">The <c>MigratingVm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cloneJobId">The <c>CloneJob</c> ID. Must not be <c>null</c> or empty.</param>
        public CloneJobName(string projectId, string locationId, string sourceId, string migratingVmId, string cloneJobId) : this(ResourceNameType.ProjectLocationSourceMigratingVmCloneJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), migratingVmId: gax::GaxPreconditions.CheckNotNullOrEmpty(migratingVmId, nameof(migratingVmId)), cloneJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(cloneJobId, nameof(cloneJobId)))
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
        /// The <c>CloneJob</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CloneJobId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>MigratingVm</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string MigratingVmId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Source</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SourceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSourceMigratingVmCloneJob: return s_projectLocationSourceMigratingVmCloneJob.Expand(ProjectId, LocationId, SourceId, MigratingVmId, CloneJobId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CloneJobName);

        /// <inheritdoc/>
        public bool Equals(CloneJobName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CloneJobName a, CloneJobName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CloneJobName a, CloneJobName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>CutoverJob</c> resource.</summary>
    public sealed partial class CutoverJobName : gax::IResourceName, sys::IEquatable<CutoverJobName>
    {
        /// <summary>The possible contents of <see cref="CutoverJobName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/cutoverJobs/{cutover_job}</c>
            /// .
            /// </summary>
            ProjectLocationSourceMigratingVmCutoverJob = 1,
        }

        private static gax::PathTemplate s_projectLocationSourceMigratingVmCutoverJob = new gax::PathTemplate("projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/cutoverJobs/{cutover_job}");

        /// <summary>Creates a <see cref="CutoverJobName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CutoverJobName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CutoverJobName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CutoverJobName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CutoverJobName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/cutoverJobs/{cutover_job}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="migratingVmId">The <c>MigratingVm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cutoverJobId">The <c>CutoverJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CutoverJobName"/> constructed from the provided ids.</returns>
        public static CutoverJobName FromProjectLocationSourceMigratingVmCutoverJob(string projectId, string locationId, string sourceId, string migratingVmId, string cutoverJobId) =>
            new CutoverJobName(ResourceNameType.ProjectLocationSourceMigratingVmCutoverJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), migratingVmId: gax::GaxPreconditions.CheckNotNullOrEmpty(migratingVmId, nameof(migratingVmId)), cutoverJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(cutoverJobId, nameof(cutoverJobId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CutoverJobName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/cutoverJobs/{cutover_job}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="migratingVmId">The <c>MigratingVm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cutoverJobId">The <c>CutoverJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CutoverJobName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/cutoverJobs/{cutover_job}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string sourceId, string migratingVmId, string cutoverJobId) =>
            FormatProjectLocationSourceMigratingVmCutoverJob(projectId, locationId, sourceId, migratingVmId, cutoverJobId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CutoverJobName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/cutoverJobs/{cutover_job}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="migratingVmId">The <c>MigratingVm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cutoverJobId">The <c>CutoverJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CutoverJobName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/cutoverJobs/{cutover_job}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationSourceMigratingVmCutoverJob(string projectId, string locationId, string sourceId, string migratingVmId, string cutoverJobId) =>
            s_projectLocationSourceMigratingVmCutoverJob.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(migratingVmId, nameof(migratingVmId)), gax::GaxPreconditions.CheckNotNullOrEmpty(cutoverJobId, nameof(cutoverJobId)));

        /// <summary>Parses the given resource name string into a new <see cref="CutoverJobName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/cutoverJobs/{cutover_job}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="cutoverJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CutoverJobName"/> if successful.</returns>
        public static CutoverJobName Parse(string cutoverJobName) => Parse(cutoverJobName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CutoverJobName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/cutoverJobs/{cutover_job}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cutoverJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CutoverJobName"/> if successful.</returns>
        public static CutoverJobName Parse(string cutoverJobName, bool allowUnparsed) =>
            TryParse(cutoverJobName, allowUnparsed, out CutoverJobName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CutoverJobName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/cutoverJobs/{cutover_job}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="cutoverJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CutoverJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cutoverJobName, out CutoverJobName result) =>
            TryParse(cutoverJobName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CutoverJobName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/cutoverJobs/{cutover_job}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cutoverJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CutoverJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cutoverJobName, bool allowUnparsed, out CutoverJobName result)
        {
            gax::GaxPreconditions.CheckNotNull(cutoverJobName, nameof(cutoverJobName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSourceMigratingVmCutoverJob.TryParseName(cutoverJobName, out resourceName))
            {
                result = FromProjectLocationSourceMigratingVmCutoverJob(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(cutoverJobName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CutoverJobName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string cutoverJobId = null, string locationId = null, string migratingVmId = null, string projectId = null, string sourceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CutoverJobId = cutoverJobId;
            LocationId = locationId;
            MigratingVmId = migratingVmId;
            ProjectId = projectId;
            SourceId = sourceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CutoverJobName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/sources/{source}/migratingVms/{migrating_vm}/cutoverJobs/{cutover_job}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="migratingVmId">The <c>MigratingVm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cutoverJobId">The <c>CutoverJob</c> ID. Must not be <c>null</c> or empty.</param>
        public CutoverJobName(string projectId, string locationId, string sourceId, string migratingVmId, string cutoverJobId) : this(ResourceNameType.ProjectLocationSourceMigratingVmCutoverJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), migratingVmId: gax::GaxPreconditions.CheckNotNullOrEmpty(migratingVmId, nameof(migratingVmId)), cutoverJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(cutoverJobId, nameof(cutoverJobId)))
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
        /// The <c>CutoverJob</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CutoverJobId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>MigratingVm</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string MigratingVmId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Source</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SourceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSourceMigratingVmCutoverJob: return s_projectLocationSourceMigratingVmCutoverJob.Expand(ProjectId, LocationId, SourceId, MigratingVmId, CutoverJobId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CutoverJobName);

        /// <inheritdoc/>
        public bool Equals(CutoverJobName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CutoverJobName a, CutoverJobName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CutoverJobName a, CutoverJobName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Source</c> resource.</summary>
    public sealed partial class SourceName : gax::IResourceName, sys::IEquatable<SourceName>
    {
        /// <summary>The possible contents of <see cref="SourceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/sources/{source}</c>.
            /// </summary>
            ProjectLocationSource = 1,
        }

        private static gax::PathTemplate s_projectLocationSource = new gax::PathTemplate("projects/{project}/locations/{location}/sources/{source}");

        /// <summary>Creates a <see cref="SourceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SourceName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SourceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SourceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SourceName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SourceName"/> constructed from the provided ids.</returns>
        public static SourceName FromProjectLocationSource(string projectId, string locationId, string sourceId) =>
            new SourceName(ResourceNameType.ProjectLocationSource, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SourceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SourceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string sourceId) =>
            FormatProjectLocationSource(projectId, locationId, sourceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SourceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SourceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}</c>.
        /// </returns>
        public static string FormatProjectLocationSource(string projectId, string locationId, string sourceId) =>
            s_projectLocationSource.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)));

        /// <summary>Parses the given resource name string into a new <see cref="SourceName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/sources/{source}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="sourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SourceName"/> if successful.</returns>
        public static SourceName Parse(string sourceName) => Parse(sourceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SourceName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/sources/{source}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SourceName"/> if successful.</returns>
        public static SourceName Parse(string sourceName, bool allowUnparsed) =>
            TryParse(sourceName, allowUnparsed, out SourceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SourceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/sources/{source}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="sourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SourceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sourceName, out SourceName result) => TryParse(sourceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SourceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/sources/{source}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SourceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sourceName, bool allowUnparsed, out SourceName result)
        {
            gax::GaxPreconditions.CheckNotNull(sourceName, nameof(sourceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSource.TryParseName(sourceName, out resourceName))
            {
                result = FromProjectLocationSource(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(sourceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SourceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string sourceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            SourceId = sourceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SourceName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        public SourceName(string projectId, string locationId, string sourceId) : this(ResourceNameType.ProjectLocationSource, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)))
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
        /// The <c>Source</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SourceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSource: return s_projectLocationSource.Expand(ProjectId, LocationId, SourceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SourceName);

        /// <inheritdoc/>
        public bool Equals(SourceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SourceName a, SourceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SourceName a, SourceName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>DatacenterConnector</c> resource.</summary>
    public sealed partial class DatacenterConnectorName : gax::IResourceName, sys::IEquatable<DatacenterConnectorName>
    {
        /// <summary>The possible contents of <see cref="DatacenterConnectorName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/sources/{source}/datacenterConnectors/{datacenter_connector}</c>
            /// .
            /// </summary>
            ProjectLocationSourceDatacenterConnector = 1,
        }

        private static gax::PathTemplate s_projectLocationSourceDatacenterConnector = new gax::PathTemplate("projects/{project}/locations/{location}/sources/{source}/datacenterConnectors/{datacenter_connector}");

        /// <summary>Creates a <see cref="DatacenterConnectorName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DatacenterConnectorName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DatacenterConnectorName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DatacenterConnectorName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DatacenterConnectorName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}/datacenterConnectors/{datacenter_connector}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datacenterConnectorId">
        /// The <c>DatacenterConnector</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="DatacenterConnectorName"/> constructed from the provided ids.
        /// </returns>
        public static DatacenterConnectorName FromProjectLocationSourceDatacenterConnector(string projectId, string locationId, string sourceId, string datacenterConnectorId) =>
            new DatacenterConnectorName(ResourceNameType.ProjectLocationSourceDatacenterConnector, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), datacenterConnectorId: gax::GaxPreconditions.CheckNotNullOrEmpty(datacenterConnectorId, nameof(datacenterConnectorId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DatacenterConnectorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}/datacenterConnectors/{datacenter_connector}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datacenterConnectorId">
        /// The <c>DatacenterConnector</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="DatacenterConnectorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}/datacenterConnectors/{datacenter_connector}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string sourceId, string datacenterConnectorId) =>
            FormatProjectLocationSourceDatacenterConnector(projectId, locationId, sourceId, datacenterConnectorId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DatacenterConnectorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}/datacenterConnectors/{datacenter_connector}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datacenterConnectorId">
        /// The <c>DatacenterConnector</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="DatacenterConnectorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}/datacenterConnectors/{datacenter_connector}</c>.
        /// </returns>
        public static string FormatProjectLocationSourceDatacenterConnector(string projectId, string locationId, string sourceId, string datacenterConnectorId) =>
            s_projectLocationSourceDatacenterConnector.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(datacenterConnectorId, nameof(datacenterConnectorId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DatacenterConnectorName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/sources/{source}/datacenterConnectors/{datacenter_connector}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="datacenterConnectorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DatacenterConnectorName"/> if successful.</returns>
        public static DatacenterConnectorName Parse(string datacenterConnectorName) => Parse(datacenterConnectorName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DatacenterConnectorName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/sources/{source}/datacenterConnectors/{datacenter_connector}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="datacenterConnectorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DatacenterConnectorName"/> if successful.</returns>
        public static DatacenterConnectorName Parse(string datacenterConnectorName, bool allowUnparsed) =>
            TryParse(datacenterConnectorName, allowUnparsed, out DatacenterConnectorName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DatacenterConnectorName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/sources/{source}/datacenterConnectors/{datacenter_connector}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="datacenterConnectorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DatacenterConnectorName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string datacenterConnectorName, out DatacenterConnectorName result) =>
            TryParse(datacenterConnectorName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DatacenterConnectorName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/sources/{source}/datacenterConnectors/{datacenter_connector}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="datacenterConnectorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DatacenterConnectorName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string datacenterConnectorName, bool allowUnparsed, out DatacenterConnectorName result)
        {
            gax::GaxPreconditions.CheckNotNull(datacenterConnectorName, nameof(datacenterConnectorName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSourceDatacenterConnector.TryParseName(datacenterConnectorName, out resourceName))
            {
                result = FromProjectLocationSourceDatacenterConnector(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(datacenterConnectorName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DatacenterConnectorName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string datacenterConnectorId = null, string locationId = null, string projectId = null, string sourceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DatacenterConnectorId = datacenterConnectorId;
            LocationId = locationId;
            ProjectId = projectId;
            SourceId = sourceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DatacenterConnectorName"/> class from the component parts of
        /// pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}/datacenterConnectors/{datacenter_connector}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datacenterConnectorId">
        /// The <c>DatacenterConnector</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public DatacenterConnectorName(string projectId, string locationId, string sourceId, string datacenterConnectorId) : this(ResourceNameType.ProjectLocationSourceDatacenterConnector, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), datacenterConnectorId: gax::GaxPreconditions.CheckNotNullOrEmpty(datacenterConnectorId, nameof(datacenterConnectorId)))
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
        /// The <c>DatacenterConnector</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string DatacenterConnectorId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Source</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SourceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSourceDatacenterConnector: return s_projectLocationSourceDatacenterConnector.Expand(ProjectId, LocationId, SourceId, DatacenterConnectorId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DatacenterConnectorName);

        /// <inheritdoc/>
        public bool Equals(DatacenterConnectorName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DatacenterConnectorName a, DatacenterConnectorName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DatacenterConnectorName a, DatacenterConnectorName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>UtilizationReport</c> resource.</summary>
    public sealed partial class UtilizationReportName : gax::IResourceName, sys::IEquatable<UtilizationReportName>
    {
        /// <summary>The possible contents of <see cref="UtilizationReportName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/sources/{source}/utilizationReports/{utilization_report}</c>.
            /// </summary>
            ProjectLocationSourceUtilizationReport = 1,
        }

        private static gax::PathTemplate s_projectLocationSourceUtilizationReport = new gax::PathTemplate("projects/{project}/locations/{location}/sources/{source}/utilizationReports/{utilization_report}");

        /// <summary>Creates a <see cref="UtilizationReportName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="UtilizationReportName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static UtilizationReportName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new UtilizationReportName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="UtilizationReportName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}/utilizationReports/{utilization_report}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="utilizationReportId">The <c>UtilizationReport</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="UtilizationReportName"/> constructed from the provided ids.</returns>
        public static UtilizationReportName FromProjectLocationSourceUtilizationReport(string projectId, string locationId, string sourceId, string utilizationReportId) =>
            new UtilizationReportName(ResourceNameType.ProjectLocationSourceUtilizationReport, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), utilizationReportId: gax::GaxPreconditions.CheckNotNullOrEmpty(utilizationReportId, nameof(utilizationReportId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UtilizationReportName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}/utilizationReports/{utilization_report}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="utilizationReportId">The <c>UtilizationReport</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="UtilizationReportName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}/utilizationReports/{utilization_report}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string sourceId, string utilizationReportId) =>
            FormatProjectLocationSourceUtilizationReport(projectId, locationId, sourceId, utilizationReportId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UtilizationReportName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}/utilizationReports/{utilization_report}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="utilizationReportId">The <c>UtilizationReport</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="UtilizationReportName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}/utilizationReports/{utilization_report}</c>.
        /// </returns>
        public static string FormatProjectLocationSourceUtilizationReport(string projectId, string locationId, string sourceId, string utilizationReportId) =>
            s_projectLocationSourceUtilizationReport.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(utilizationReportId, nameof(utilizationReportId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="UtilizationReportName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/sources/{source}/utilizationReports/{utilization_report}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="utilizationReportName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="UtilizationReportName"/> if successful.</returns>
        public static UtilizationReportName Parse(string utilizationReportName) => Parse(utilizationReportName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="UtilizationReportName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/sources/{source}/utilizationReports/{utilization_report}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="utilizationReportName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="UtilizationReportName"/> if successful.</returns>
        public static UtilizationReportName Parse(string utilizationReportName, bool allowUnparsed) =>
            TryParse(utilizationReportName, allowUnparsed, out UtilizationReportName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UtilizationReportName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/sources/{source}/utilizationReports/{utilization_report}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="utilizationReportName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UtilizationReportName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string utilizationReportName, out UtilizationReportName result) =>
            TryParse(utilizationReportName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UtilizationReportName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/sources/{source}/utilizationReports/{utilization_report}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="utilizationReportName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UtilizationReportName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string utilizationReportName, bool allowUnparsed, out UtilizationReportName result)
        {
            gax::GaxPreconditions.CheckNotNull(utilizationReportName, nameof(utilizationReportName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSourceUtilizationReport.TryParseName(utilizationReportName, out resourceName))
            {
                result = FromProjectLocationSourceUtilizationReport(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(utilizationReportName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private UtilizationReportName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string sourceId = null, string utilizationReportId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            SourceId = sourceId;
            UtilizationReportId = utilizationReportId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="UtilizationReportName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/sources/{source}/utilizationReports/{utilization_report}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="utilizationReportId">The <c>UtilizationReport</c> ID. Must not be <c>null</c> or empty.</param>
        public UtilizationReportName(string projectId, string locationId, string sourceId, string utilizationReportId) : this(ResourceNameType.ProjectLocationSourceUtilizationReport, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), utilizationReportId: gax::GaxPreconditions.CheckNotNullOrEmpty(utilizationReportId, nameof(utilizationReportId)))
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
        /// The <c>Source</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SourceId { get; }

        /// <summary>
        /// The <c>UtilizationReport</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string UtilizationReportId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSourceUtilizationReport: return s_projectLocationSourceUtilizationReport.Expand(ProjectId, LocationId, SourceId, UtilizationReportId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as UtilizationReportName);

        /// <inheritdoc/>
        public bool Equals(UtilizationReportName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(UtilizationReportName a, UtilizationReportName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(UtilizationReportName a, UtilizationReportName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>TargetProject</c> resource.</summary>
    public sealed partial class TargetProjectName : gax::IResourceName, sys::IEquatable<TargetProjectName>
    {
        /// <summary>The possible contents of <see cref="TargetProjectName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/targetProjects/{target_project}</c>
            /// .
            /// </summary>
            ProjectLocationTargetProject = 1,
        }

        private static gax::PathTemplate s_projectLocationTargetProject = new gax::PathTemplate("projects/{project}/locations/{location}/targetProjects/{target_project}");

        /// <summary>Creates a <see cref="TargetProjectName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TargetProjectName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TargetProjectName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TargetProjectName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TargetProjectName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/targetProjects/{target_project}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="targetProjectId">The <c>TargetProject</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TargetProjectName"/> constructed from the provided ids.</returns>
        public static TargetProjectName FromProjectLocationTargetProject(string projectId, string locationId, string targetProjectId) =>
            new TargetProjectName(ResourceNameType.ProjectLocationTargetProject, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), targetProjectId: gax::GaxPreconditions.CheckNotNullOrEmpty(targetProjectId, nameof(targetProjectId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TargetProjectName"/> with pattern
        /// <c>projects/{project}/locations/{location}/targetProjects/{target_project}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="targetProjectId">The <c>TargetProject</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TargetProjectName"/> with pattern
        /// <c>projects/{project}/locations/{location}/targetProjects/{target_project}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string targetProjectId) =>
            FormatProjectLocationTargetProject(projectId, locationId, targetProjectId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TargetProjectName"/> with pattern
        /// <c>projects/{project}/locations/{location}/targetProjects/{target_project}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="targetProjectId">The <c>TargetProject</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TargetProjectName"/> with pattern
        /// <c>projects/{project}/locations/{location}/targetProjects/{target_project}</c>.
        /// </returns>
        public static string FormatProjectLocationTargetProject(string projectId, string locationId, string targetProjectId) =>
            s_projectLocationTargetProject.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(targetProjectId, nameof(targetProjectId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TargetProjectName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/targetProjects/{target_project}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="targetProjectName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TargetProjectName"/> if successful.</returns>
        public static TargetProjectName Parse(string targetProjectName) => Parse(targetProjectName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TargetProjectName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/targetProjects/{target_project}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="targetProjectName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TargetProjectName"/> if successful.</returns>
        public static TargetProjectName Parse(string targetProjectName, bool allowUnparsed) =>
            TryParse(targetProjectName, allowUnparsed, out TargetProjectName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TargetProjectName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/targetProjects/{target_project}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="targetProjectName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TargetProjectName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string targetProjectName, out TargetProjectName result) =>
            TryParse(targetProjectName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TargetProjectName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/targetProjects/{target_project}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="targetProjectName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TargetProjectName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string targetProjectName, bool allowUnparsed, out TargetProjectName result)
        {
            gax::GaxPreconditions.CheckNotNull(targetProjectName, nameof(targetProjectName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationTargetProject.TryParseName(targetProjectName, out resourceName))
            {
                result = FromProjectLocationTargetProject(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(targetProjectName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TargetProjectName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string targetProjectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            TargetProjectId = targetProjectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TargetProjectName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/targetProjects/{target_project}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="targetProjectId">The <c>TargetProject</c> ID. Must not be <c>null</c> or empty.</param>
        public TargetProjectName(string projectId, string locationId, string targetProjectId) : this(ResourceNameType.ProjectLocationTargetProject, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), targetProjectId: gax::GaxPreconditions.CheckNotNullOrEmpty(targetProjectId, nameof(targetProjectId)))
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
        /// The <c>TargetProject</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string TargetProjectId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationTargetProject: return s_projectLocationTargetProject.Expand(ProjectId, LocationId, TargetProjectId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TargetProjectName);

        /// <inheritdoc/>
        public bool Equals(TargetProjectName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TargetProjectName a, TargetProjectName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TargetProjectName a, TargetProjectName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Group</c> resource.</summary>
    public sealed partial class GroupName : gax::IResourceName, sys::IEquatable<GroupName>
    {
        /// <summary>The possible contents of <see cref="GroupName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/groups/{group}</c>.
            /// </summary>
            ProjectLocationGroup = 1,
        }

        private static gax::PathTemplate s_projectLocationGroup = new gax::PathTemplate("projects/{project}/locations/{location}/groups/{group}");

        /// <summary>Creates a <see cref="GroupName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="GroupName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static GroupName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new GroupName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="GroupName"/> with the pattern <c>projects/{project}/locations/{location}/groups/{group}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="groupId">The <c>Group</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="GroupName"/> constructed from the provided ids.</returns>
        public static GroupName FromProjectLocationGroup(string projectId, string locationId, string groupId) =>
            new GroupName(ResourceNameType.ProjectLocationGroup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), groupId: gax::GaxPreconditions.CheckNotNullOrEmpty(groupId, nameof(groupId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/groups/{group}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="groupId">The <c>Group</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/groups/{group}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string groupId) =>
            FormatProjectLocationGroup(projectId, locationId, groupId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/groups/{group}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="groupId">The <c>Group</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/groups/{group}</c>.
        /// </returns>
        public static string FormatProjectLocationGroup(string projectId, string locationId, string groupId) =>
            s_projectLocationGroup.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(groupId, nameof(groupId)));

        /// <summary>Parses the given resource name string into a new <see cref="GroupName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/groups/{group}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="groupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GroupName"/> if successful.</returns>
        public static GroupName Parse(string groupName) => Parse(groupName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GroupName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/groups/{group}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="groupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="GroupName"/> if successful.</returns>
        public static GroupName Parse(string groupName, bool allowUnparsed) =>
            TryParse(groupName, allowUnparsed, out GroupName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/groups/{group}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="groupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GroupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string groupName, out GroupName result) => TryParse(groupName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GroupName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/groups/{group}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="groupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GroupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string groupName, bool allowUnparsed, out GroupName result)
        {
            gax::GaxPreconditions.CheckNotNull(groupName, nameof(groupName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationGroup.TryParseName(groupName, out resourceName))
            {
                result = FromProjectLocationGroup(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(groupName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private GroupName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string groupId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            GroupId = groupId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="GroupName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/groups/{group}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="groupId">The <c>Group</c> ID. Must not be <c>null</c> or empty.</param>
        public GroupName(string projectId, string locationId, string groupId) : this(ResourceNameType.ProjectLocationGroup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), groupId: gax::GaxPreconditions.CheckNotNullOrEmpty(groupId, nameof(groupId)))
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
        /// The <c>Group</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string GroupId { get; }

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
                case ResourceNameType.ProjectLocationGroup: return s_projectLocationGroup.Expand(ProjectId, LocationId, GroupId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as GroupName);

        /// <inheritdoc/>
        public bool Equals(GroupName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(GroupName a, GroupName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(GroupName a, GroupName b) => !(a == b);
    }

    public partial class ReplicationCycle
    {
        /// <summary>
        /// <see cref="gcvv::ReplicationCycleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ReplicationCycleName ReplicationCycleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ReplicationCycleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class MigratingVm
    {
        /// <summary>
        /// <see cref="gcvv::MigratingVmName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::MigratingVmName MigratingVmName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::MigratingVmName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Group"/> resource name property.
        /// </summary>
        public gagr::LocationName GroupAsLocationName
        {
            get => string.IsNullOrEmpty(Group) ? null : gagr::LocationName.Parse(Group, allowUnparsed: true);
            set => Group = value?.ToString() ?? "";
        }
    }

    public partial class CloneJob
    {
        /// <summary>
        /// <see cref="gcvv::CloneJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::CloneJobName CloneJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::CloneJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CutoverJob
    {
        /// <summary>
        /// <see cref="gcvv::CutoverJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::CutoverJobName CutoverJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::CutoverJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateCloneJobRequest
    {
        /// <summary>
        /// <see cref="MigratingVmName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public MigratingVmName ParentAsMigratingVmName
        {
            get => string.IsNullOrEmpty(Parent) ? null : MigratingVmName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CancelCloneJobRequest
    {
        /// <summary>
        /// <see cref="gcvv::CloneJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::CloneJobName CloneJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::CloneJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListCloneJobsRequest
    {
        /// <summary>
        /// <see cref="MigratingVmName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public MigratingVmName ParentAsMigratingVmName
        {
            get => string.IsNullOrEmpty(Parent) ? null : MigratingVmName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetCloneJobRequest
    {
        /// <summary>
        /// <see cref="gcvv::CloneJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::CloneJobName CloneJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::CloneJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Source
    {
        /// <summary>
        /// <see cref="gcvv::SourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::SourceName SourceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::SourceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DatacenterConnector
    {
        /// <summary>
        /// <see cref="gcvv::DatacenterConnectorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::DatacenterConnectorName DatacenterConnectorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::DatacenterConnectorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSourcesRequest
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

    public partial class GetSourceRequest
    {
        /// <summary>
        /// <see cref="gcvv::SourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::SourceName SourceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::SourceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateSourceRequest
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

    public partial class DeleteSourceRequest
    {
        /// <summary>
        /// <see cref="gcvv::SourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::SourceName SourceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::SourceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class FetchInventoryRequest
    {
        /// <summary><see cref="SourceName"/>-typed view over the <see cref="Source"/> resource name property.</summary>
        public SourceName SourceAsSourceName
        {
            get => string.IsNullOrEmpty(Source) ? null : SourceName.Parse(Source, allowUnparsed: true);
            set => Source = value?.ToString() ?? "";
        }
    }

    public partial class UtilizationReport
    {
        /// <summary>
        /// <see cref="gcvv::UtilizationReportName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::UtilizationReportName UtilizationReportName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::UtilizationReportName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListUtilizationReportsRequest
    {
        /// <summary><see cref="SourceName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public SourceName ParentAsSourceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SourceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetUtilizationReportRequest
    {
        /// <summary>
        /// <see cref="gcvv::UtilizationReportName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::UtilizationReportName UtilizationReportName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::UtilizationReportName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateUtilizationReportRequest
    {
        /// <summary><see cref="SourceName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public SourceName ParentAsSourceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SourceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteUtilizationReportRequest
    {
        /// <summary>
        /// <see cref="gcvv::UtilizationReportName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::UtilizationReportName UtilizationReportName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::UtilizationReportName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetDatacenterConnectorRequest
    {
        /// <summary>
        /// <see cref="gcvv::DatacenterConnectorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::DatacenterConnectorName DatacenterConnectorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::DatacenterConnectorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateDatacenterConnectorRequest
    {
        /// <summary><see cref="SourceName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public SourceName ParentAsSourceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SourceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteDatacenterConnectorRequest
    {
        /// <summary>
        /// <see cref="gcvv::DatacenterConnectorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::DatacenterConnectorName DatacenterConnectorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::DatacenterConnectorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class UpgradeApplianceRequest
    {
        /// <summary>
        /// <see cref="DatacenterConnectorName"/>-typed view over the <see cref="DatacenterConnector"/> resource name
        /// property.
        /// </summary>
        public DatacenterConnectorName DatacenterConnectorAsDatacenterConnectorName
        {
            get => string.IsNullOrEmpty(DatacenterConnector) ? null : DatacenterConnectorName.Parse(DatacenterConnector, allowUnparsed: true);
            set => DatacenterConnector = value?.ToString() ?? "";
        }
    }

    public partial class ListDatacenterConnectorsRequest
    {
        /// <summary><see cref="SourceName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public SourceName ParentAsSourceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SourceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ComputeEngineTargetDefaults
    {
        /// <summary>
        /// <see cref="TargetProjectName"/>-typed view over the <see cref="TargetProject"/> resource name property.
        /// </summary>
        public TargetProjectName TargetProjectAsTargetProjectName
        {
            get => string.IsNullOrEmpty(TargetProject) ? null : TargetProjectName.Parse(TargetProject, allowUnparsed: true);
            set => TargetProject = value?.ToString() ?? "";
        }
    }

    public partial class CreateMigratingVmRequest
    {
        /// <summary><see cref="SourceName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public SourceName ParentAsSourceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SourceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListMigratingVmsRequest
    {
        /// <summary><see cref="SourceName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public SourceName ParentAsSourceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SourceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetMigratingVmRequest
    {
        /// <summary>
        /// <see cref="gcvv::MigratingVmName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::MigratingVmName MigratingVmName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::MigratingVmName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteMigratingVmRequest
    {
        /// <summary>
        /// <see cref="gcvv::MigratingVmName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::MigratingVmName MigratingVmName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::MigratingVmName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class StartMigrationRequest
    {
        /// <summary>
        /// <see cref="MigratingVmName"/>-typed view over the <see cref="MigratingVm"/> resource name property.
        /// </summary>
        public MigratingVmName MigratingVmAsMigratingVmName
        {
            get => string.IsNullOrEmpty(MigratingVm) ? null : MigratingVmName.Parse(MigratingVm, allowUnparsed: true);
            set => MigratingVm = value?.ToString() ?? "";
        }
    }

    public partial class PauseMigrationRequest
    {
        /// <summary>
        /// <see cref="MigratingVmName"/>-typed view over the <see cref="MigratingVm"/> resource name property.
        /// </summary>
        public MigratingVmName MigratingVmAsMigratingVmName
        {
            get => string.IsNullOrEmpty(MigratingVm) ? null : MigratingVmName.Parse(MigratingVm, allowUnparsed: true);
            set => MigratingVm = value?.ToString() ?? "";
        }
    }

    public partial class ResumeMigrationRequest
    {
        /// <summary>
        /// <see cref="MigratingVmName"/>-typed view over the <see cref="MigratingVm"/> resource name property.
        /// </summary>
        public MigratingVmName MigratingVmAsMigratingVmName
        {
            get => string.IsNullOrEmpty(MigratingVm) ? null : MigratingVmName.Parse(MigratingVm, allowUnparsed: true);
            set => MigratingVm = value?.ToString() ?? "";
        }
    }

    public partial class FinalizeMigrationRequest
    {
        /// <summary>
        /// <see cref="MigratingVmName"/>-typed view over the <see cref="MigratingVm"/> resource name property.
        /// </summary>
        public MigratingVmName MigratingVmAsMigratingVmName
        {
            get => string.IsNullOrEmpty(MigratingVm) ? null : MigratingVmName.Parse(MigratingVm, allowUnparsed: true);
            set => MigratingVm = value?.ToString() ?? "";
        }
    }

    public partial class TargetProject
    {
        /// <summary>
        /// <see cref="gcvv::TargetProjectName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::TargetProjectName TargetProjectName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::TargetProjectName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetTargetProjectRequest
    {
        /// <summary>
        /// <see cref="gcvv::TargetProjectName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::TargetProjectName TargetProjectName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::TargetProjectName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListTargetProjectsRequest
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

    public partial class CreateTargetProjectRequest
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

    public partial class DeleteTargetProjectRequest
    {
        /// <summary>
        /// <see cref="gcvv::TargetProjectName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::TargetProjectName TargetProjectName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::TargetProjectName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Group
    {
        /// <summary>
        /// <see cref="gcvv::GroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::GroupName GroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::GroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListGroupsRequest
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

    public partial class GetGroupRequest
    {
        /// <summary>
        /// <see cref="gcvv::GroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::GroupName GroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::GroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateGroupRequest
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

    public partial class DeleteGroupRequest
    {
        /// <summary>
        /// <see cref="gcvv::GroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::GroupName GroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::GroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AddGroupMigrationRequest
    {
        /// <summary><see cref="GroupName"/>-typed view over the <see cref="Group"/> resource name property.</summary>
        public GroupName GroupAsGroupName
        {
            get => string.IsNullOrEmpty(Group) ? null : GroupName.Parse(Group, allowUnparsed: true);
            set => Group = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="MigratingVmName"/>-typed view over the <see cref="MigratingVm"/> resource name property.
        /// </summary>
        public MigratingVmName MigratingVmAsMigratingVmName
        {
            get => string.IsNullOrEmpty(MigratingVm) ? null : MigratingVmName.Parse(MigratingVm, allowUnparsed: true);
            set => MigratingVm = value?.ToString() ?? "";
        }
    }

    public partial class RemoveGroupMigrationRequest
    {
        /// <summary><see cref="GroupName"/>-typed view over the <see cref="Group"/> resource name property.</summary>
        public GroupName GroupAsGroupName
        {
            get => string.IsNullOrEmpty(Group) ? null : GroupName.Parse(Group, allowUnparsed: true);
            set => Group = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="MigratingVmName"/>-typed view over the <see cref="MigratingVm"/> resource name property.
        /// </summary>
        public MigratingVmName MigratingVmAsMigratingVmName
        {
            get => string.IsNullOrEmpty(MigratingVm) ? null : MigratingVmName.Parse(MigratingVm, allowUnparsed: true);
            set => MigratingVm = value?.ToString() ?? "";
        }
    }

    public partial class CreateCutoverJobRequest
    {
        /// <summary>
        /// <see cref="MigratingVmName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public MigratingVmName ParentAsMigratingVmName
        {
            get => string.IsNullOrEmpty(Parent) ? null : MigratingVmName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CancelCutoverJobRequest
    {
        /// <summary>
        /// <see cref="gcvv::CutoverJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::CutoverJobName CutoverJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::CutoverJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListCutoverJobsRequest
    {
        /// <summary>
        /// <see cref="MigratingVmName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public MigratingVmName ParentAsMigratingVmName
        {
            get => string.IsNullOrEmpty(Parent) ? null : MigratingVmName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetCutoverJobRequest
    {
        /// <summary>
        /// <see cref="gcvv::CutoverJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::CutoverJobName CutoverJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::CutoverJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListReplicationCyclesRequest
    {
        /// <summary>
        /// <see cref="MigratingVmName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public MigratingVmName ParentAsMigratingVmName
        {
            get => string.IsNullOrEmpty(Parent) ? null : MigratingVmName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetReplicationCycleRequest
    {
        /// <summary>
        /// <see cref="gcvv::ReplicationCycleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ReplicationCycleName ReplicationCycleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ReplicationCycleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
