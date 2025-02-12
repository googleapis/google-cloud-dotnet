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
using gcsadv = Google.Cloud.Spanner.Admin.Database.V1;
using gcscv = Google.Cloud.Spanner.Common.V1;
using sys = System;

namespace Google.Cloud.Spanner.Admin.Database.V1
{
    /// <summary>Resource name for the <c>DatabaseRole</c> resource.</summary>
    public sealed partial class DatabaseRoleName : gax::IResourceName, sys::IEquatable<DatabaseRoleName>
    {
        /// <summary>The possible contents of <see cref="DatabaseRoleName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/instances/{instance}/databases/{database}/databaseRoles/{role}</c>.
            /// </summary>
            ProjectInstanceDatabaseRole = 1,
        }

        private static gax::PathTemplate s_projectInstanceDatabaseRole = new gax::PathTemplate("projects/{project}/instances/{instance}/databases/{database}/databaseRoles/{role}");

        /// <summary>Creates a <see cref="DatabaseRoleName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DatabaseRoleName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DatabaseRoleName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DatabaseRoleName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DatabaseRoleName"/> with the pattern
        /// <c>projects/{project}/instances/{instance}/databases/{database}/databaseRoles/{role}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="roleId">The <c>Role</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DatabaseRoleName"/> constructed from the provided ids.</returns>
        public static DatabaseRoleName FromProjectInstanceDatabaseRole(string projectId, string instanceId, string databaseId, string roleId) =>
            new DatabaseRoleName(ResourceNameType.ProjectInstanceDatabaseRole, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), databaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(databaseId, nameof(databaseId)), roleId: gax::GaxPreconditions.CheckNotNullOrEmpty(roleId, nameof(roleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DatabaseRoleName"/> with pattern
        /// <c>projects/{project}/instances/{instance}/databases/{database}/databaseRoles/{role}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="roleId">The <c>Role</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DatabaseRoleName"/> with pattern
        /// <c>projects/{project}/instances/{instance}/databases/{database}/databaseRoles/{role}</c>.
        /// </returns>
        public static string Format(string projectId, string instanceId, string databaseId, string roleId) =>
            FormatProjectInstanceDatabaseRole(projectId, instanceId, databaseId, roleId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DatabaseRoleName"/> with pattern
        /// <c>projects/{project}/instances/{instance}/databases/{database}/databaseRoles/{role}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="roleId">The <c>Role</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DatabaseRoleName"/> with pattern
        /// <c>projects/{project}/instances/{instance}/databases/{database}/databaseRoles/{role}</c>.
        /// </returns>
        public static string FormatProjectInstanceDatabaseRole(string projectId, string instanceId, string databaseId, string roleId) =>
            s_projectInstanceDatabaseRole.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(databaseId, nameof(databaseId)), gax::GaxPreconditions.CheckNotNullOrEmpty(roleId, nameof(roleId)));

        /// <summary>Parses the given resource name string into a new <see cref="DatabaseRoleName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/instances/{instance}/databases/{database}/databaseRoles/{role}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="databaseRoleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DatabaseRoleName"/> if successful.</returns>
        public static DatabaseRoleName Parse(string databaseRoleName) => Parse(databaseRoleName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DatabaseRoleName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/instances/{instance}/databases/{database}/databaseRoles/{role}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="databaseRoleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DatabaseRoleName"/> if successful.</returns>
        public static DatabaseRoleName Parse(string databaseRoleName, bool allowUnparsed) =>
            TryParse(databaseRoleName, allowUnparsed, out DatabaseRoleName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DatabaseRoleName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/instances/{instance}/databases/{database}/databaseRoles/{role}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="databaseRoleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DatabaseRoleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string databaseRoleName, out DatabaseRoleName result) =>
            TryParse(databaseRoleName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DatabaseRoleName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/instances/{instance}/databases/{database}/databaseRoles/{role}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="databaseRoleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DatabaseRoleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string databaseRoleName, bool allowUnparsed, out DatabaseRoleName result)
        {
            gax::GaxPreconditions.CheckNotNull(databaseRoleName, nameof(databaseRoleName));
            gax::TemplatedResourceName resourceName;
            if (s_projectInstanceDatabaseRole.TryParseName(databaseRoleName, out resourceName))
            {
                result = FromProjectInstanceDatabaseRole(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(databaseRoleName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DatabaseRoleName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string databaseId = null, string instanceId = null, string projectId = null, string roleId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DatabaseId = databaseId;
            InstanceId = instanceId;
            ProjectId = projectId;
            RoleId = roleId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DatabaseRoleName"/> class from the component parts of pattern
        /// <c>projects/{project}/instances/{instance}/databases/{database}/databaseRoles/{role}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="roleId">The <c>Role</c> ID. Must not be <c>null</c> or empty.</param>
        public DatabaseRoleName(string projectId, string instanceId, string databaseId, string roleId) : this(ResourceNameType.ProjectInstanceDatabaseRole, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), databaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(databaseId, nameof(databaseId)), roleId: gax::GaxPreconditions.CheckNotNullOrEmpty(roleId, nameof(roleId)))
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
        /// The <c>Database</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DatabaseId { get; }

        /// <summary>
        /// The <c>Instance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string InstanceId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Role</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RoleId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectInstanceDatabaseRole: return s_projectInstanceDatabaseRole.Expand(ProjectId, InstanceId, DatabaseId, RoleId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DatabaseRoleName);

        /// <inheritdoc/>
        public bool Equals(DatabaseRoleName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DatabaseRoleName a, DatabaseRoleName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DatabaseRoleName a, DatabaseRoleName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>InstancePartition</c> resource.</summary>
    public sealed partial class InstancePartitionName : gax::IResourceName, sys::IEquatable<InstancePartitionName>
    {
        /// <summary>The possible contents of <see cref="InstancePartitionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/instances/{instance}/instancePartitions/{instance_partition}</c>.
            /// </summary>
            ProjectInstanceInstancePartition = 1,
        }

        private static gax::PathTemplate s_projectInstanceInstancePartition = new gax::PathTemplate("projects/{project}/instances/{instance}/instancePartitions/{instance_partition}");

        /// <summary>Creates a <see cref="InstancePartitionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="InstancePartitionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static InstancePartitionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new InstancePartitionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="InstancePartitionName"/> with the pattern
        /// <c>projects/{project}/instances/{instance}/instancePartitions/{instance_partition}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instancePartitionId">The <c>InstancePartition</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="InstancePartitionName"/> constructed from the provided ids.</returns>
        public static InstancePartitionName FromProjectInstanceInstancePartition(string projectId, string instanceId, string instancePartitionId) =>
            new InstancePartitionName(ResourceNameType.ProjectInstanceInstancePartition, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), instancePartitionId: gax::GaxPreconditions.CheckNotNullOrEmpty(instancePartitionId, nameof(instancePartitionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InstancePartitionName"/> with pattern
        /// <c>projects/{project}/instances/{instance}/instancePartitions/{instance_partition}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instancePartitionId">The <c>InstancePartition</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InstancePartitionName"/> with pattern
        /// <c>projects/{project}/instances/{instance}/instancePartitions/{instance_partition}</c>.
        /// </returns>
        public static string Format(string projectId, string instanceId, string instancePartitionId) =>
            FormatProjectInstanceInstancePartition(projectId, instanceId, instancePartitionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InstancePartitionName"/> with pattern
        /// <c>projects/{project}/instances/{instance}/instancePartitions/{instance_partition}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instancePartitionId">The <c>InstancePartition</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InstancePartitionName"/> with pattern
        /// <c>projects/{project}/instances/{instance}/instancePartitions/{instance_partition}</c>.
        /// </returns>
        public static string FormatProjectInstanceInstancePartition(string projectId, string instanceId, string instancePartitionId) =>
            s_projectInstanceInstancePartition.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instancePartitionId, nameof(instancePartitionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InstancePartitionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/instances/{instance}/instancePartitions/{instance_partition}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="instancePartitionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="InstancePartitionName"/> if successful.</returns>
        public static InstancePartitionName Parse(string instancePartitionName) => Parse(instancePartitionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InstancePartitionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/instances/{instance}/instancePartitions/{instance_partition}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="instancePartitionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="InstancePartitionName"/> if successful.</returns>
        public static InstancePartitionName Parse(string instancePartitionName, bool allowUnparsed) =>
            TryParse(instancePartitionName, allowUnparsed, out InstancePartitionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InstancePartitionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/instances/{instance}/instancePartitions/{instance_partition}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="instancePartitionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InstancePartitionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instancePartitionName, out InstancePartitionName result) =>
            TryParse(instancePartitionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InstancePartitionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/instances/{instance}/instancePartitions/{instance_partition}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="instancePartitionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InstancePartitionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instancePartitionName, bool allowUnparsed, out InstancePartitionName result)
        {
            gax::GaxPreconditions.CheckNotNull(instancePartitionName, nameof(instancePartitionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectInstanceInstancePartition.TryParseName(instancePartitionName, out resourceName))
            {
                result = FromProjectInstanceInstancePartition(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(instancePartitionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private InstancePartitionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string instanceId = null, string instancePartitionId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InstanceId = instanceId;
            InstancePartitionId = instancePartitionId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="InstancePartitionName"/> class from the component parts of pattern
        /// <c>projects/{project}/instances/{instance}/instancePartitions/{instance_partition}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instancePartitionId">The <c>InstancePartition</c> ID. Must not be <c>null</c> or empty.</param>
        public InstancePartitionName(string projectId, string instanceId, string instancePartitionId) : this(ResourceNameType.ProjectInstanceInstancePartition, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), instancePartitionId: gax::GaxPreconditions.CheckNotNullOrEmpty(instancePartitionId, nameof(instancePartitionId)))
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
        /// The <c>InstancePartition</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string InstancePartitionId { get; }

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
                case ResourceNameType.ProjectInstanceInstancePartition: return s_projectInstanceInstancePartition.Expand(ProjectId, InstanceId, InstancePartitionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as InstancePartitionName);

        /// <inheritdoc/>
        public bool Equals(InstancePartitionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(InstancePartitionName a, InstancePartitionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(InstancePartitionName a, InstancePartitionName b) => !(a == b);
    }

    public partial class Database
    {
        /// <summary>
        /// <see cref="gcscv::DatabaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::DatabaseName DatabaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::DatabaseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDatabasesRequest
    {
        /// <summary>
        /// <see cref="gcscv::InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gcscv::InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gcscv::InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateDatabaseRequest
    {
        /// <summary>
        /// <see cref="gcscv::InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gcscv::InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gcscv::InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateDatabaseMetadata
    {
        /// <summary>
        /// <see cref="gcscv::DatabaseName"/>-typed view over the <see cref="Database"/> resource name property.
        /// </summary>
        public gcscv::DatabaseName DatabaseAsDatabaseName
        {
            get => string.IsNullOrEmpty(Database) ? null : gcscv::DatabaseName.Parse(Database, allowUnparsed: true);
            set => Database = value?.ToString() ?? "";
        }
    }

    public partial class GetDatabaseRequest
    {
        /// <summary>
        /// <see cref="gcscv::DatabaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::DatabaseName DatabaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::DatabaseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class UpdateDatabaseDdlRequest
    {
        /// <summary>
        /// <see cref="gcscv::DatabaseName"/>-typed view over the <see cref="Database"/> resource name property.
        /// </summary>
        public gcscv::DatabaseName DatabaseAsDatabaseName
        {
            get => string.IsNullOrEmpty(Database) ? null : gcscv::DatabaseName.Parse(Database, allowUnparsed: true);
            set => Database = value?.ToString() ?? "";
        }
    }

    public partial class UpdateDatabaseDdlMetadata
    {
        /// <summary>
        /// <see cref="gcscv::DatabaseName"/>-typed view over the <see cref="Database"/> resource name property.
        /// </summary>
        public gcscv::DatabaseName DatabaseAsDatabaseName
        {
            get => string.IsNullOrEmpty(Database) ? null : gcscv::DatabaseName.Parse(Database, allowUnparsed: true);
            set => Database = value?.ToString() ?? "";
        }
    }

    public partial class DropDatabaseRequest
    {
        /// <summary>
        /// <see cref="gcscv::DatabaseName"/>-typed view over the <see cref="Database"/> resource name property.
        /// </summary>
        public gcscv::DatabaseName DatabaseAsDatabaseName
        {
            get => string.IsNullOrEmpty(Database) ? null : gcscv::DatabaseName.Parse(Database, allowUnparsed: true);
            set => Database = value?.ToString() ?? "";
        }
    }

    public partial class GetDatabaseDdlRequest
    {
        /// <summary>
        /// <see cref="gcscv::DatabaseName"/>-typed view over the <see cref="Database"/> resource name property.
        /// </summary>
        public gcscv::DatabaseName DatabaseAsDatabaseName
        {
            get => string.IsNullOrEmpty(Database) ? null : gcscv::DatabaseName.Parse(Database, allowUnparsed: true);
            set => Database = value?.ToString() ?? "";
        }
    }

    public partial class ListDatabaseOperationsRequest
    {
        /// <summary>
        /// <see cref="gcscv::InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gcscv::InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gcscv::InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class RestoreDatabaseRequest
    {
        /// <summary>
        /// <see cref="gcscv::InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gcscv::InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gcscv::InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary><see cref="BackupName"/>-typed view over the <see cref="Backup"/> resource name property.</summary>
        public BackupName BackupAsBackupName
        {
            get => string.IsNullOrEmpty(Backup) ? null : BackupName.Parse(Backup, allowUnparsed: true);
            set => Backup = value?.ToString() ?? "";
        }
    }

    public partial class RestoreDatabaseEncryptionConfig
    {
        /// <summary>
        /// <see cref="CryptoKeyName"/>-typed view over the <see cref="KmsKeyName"/> resource name property.
        /// </summary>
        public CryptoKeyName KmsKeyNameAsCryptoKeyName
        {
            get => string.IsNullOrEmpty(KmsKeyName) ? null : CryptoKeyName.Parse(KmsKeyName, allowUnparsed: true);
            set => KmsKeyName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CryptoKeyName"/>-typed view over the <see cref="KmsKeyNames"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<CryptoKeyName> KmsKeyNamesAsCryptoKeyNames
        {
            get => new gax::ResourceNameList<CryptoKeyName>(KmsKeyNames, s => string.IsNullOrEmpty(s) ? null : CryptoKeyName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class RestoreDatabaseMetadata
    {
        /// <summary>
        /// <see cref="gcscv::DatabaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::DatabaseName DatabaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::DatabaseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class OptimizeRestoredDatabaseMetadata
    {
        /// <summary>
        /// <see cref="gcscv::DatabaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::DatabaseName DatabaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::DatabaseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DatabaseRole
    {
        /// <summary>
        /// <see cref="gcsadv::DatabaseRoleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsadv::DatabaseRoleName DatabaseRoleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsadv::DatabaseRoleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDatabaseRolesRequest
    {
        /// <summary>
        /// <see cref="gcscv::DatabaseName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gcscv::DatabaseName ParentAsDatabaseName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gcscv::DatabaseName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class AddSplitPointsRequest
    {
        /// <summary>
        /// <see cref="gcscv::DatabaseName"/>-typed view over the <see cref="Database"/> resource name property.
        /// </summary>
        public gcscv::DatabaseName DatabaseAsDatabaseName
        {
            get => string.IsNullOrEmpty(Database) ? null : gcscv::DatabaseName.Parse(Database, allowUnparsed: true);
            set => Database = value?.ToString() ?? "";
        }
    }
}
