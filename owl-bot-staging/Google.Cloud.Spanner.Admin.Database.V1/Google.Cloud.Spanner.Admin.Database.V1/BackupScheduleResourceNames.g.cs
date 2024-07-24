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
using gcsadv = Google.Cloud.Spanner.Admin.Database.V1;
using sys = System;

namespace Google.Cloud.Spanner.Admin.Database.V1
{
    /// <summary>Resource name for the <c>BackupSchedule</c> resource.</summary>
    public sealed partial class BackupScheduleName : gax::IResourceName, sys::IEquatable<BackupScheduleName>
    {
        /// <summary>The possible contents of <see cref="BackupScheduleName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/instances/{instance}/databases/{database}/backupSchedules/{schedule}</c>.
            /// </summary>
            ProjectInstanceDatabaseSchedule = 1,
        }

        private static gax::PathTemplate s_projectInstanceDatabaseSchedule = new gax::PathTemplate("projects/{project}/instances/{instance}/databases/{database}/backupSchedules/{schedule}");

        /// <summary>Creates a <see cref="BackupScheduleName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="BackupScheduleName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static BackupScheduleName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new BackupScheduleName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="BackupScheduleName"/> with the pattern
        /// <c>projects/{project}/instances/{instance}/databases/{database}/backupSchedules/{schedule}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scheduleId">The <c>Schedule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="BackupScheduleName"/> constructed from the provided ids.</returns>
        public static BackupScheduleName FromProjectInstanceDatabaseSchedule(string projectId, string instanceId, string databaseId, string scheduleId) =>
            new BackupScheduleName(ResourceNameType.ProjectInstanceDatabaseSchedule, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), databaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(databaseId, nameof(databaseId)), scheduleId: gax::GaxPreconditions.CheckNotNullOrEmpty(scheduleId, nameof(scheduleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BackupScheduleName"/> with pattern
        /// <c>projects/{project}/instances/{instance}/databases/{database}/backupSchedules/{schedule}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scheduleId">The <c>Schedule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BackupScheduleName"/> with pattern
        /// <c>projects/{project}/instances/{instance}/databases/{database}/backupSchedules/{schedule}</c>.
        /// </returns>
        public static string Format(string projectId, string instanceId, string databaseId, string scheduleId) =>
            FormatProjectInstanceDatabaseSchedule(projectId, instanceId, databaseId, scheduleId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BackupScheduleName"/> with pattern
        /// <c>projects/{project}/instances/{instance}/databases/{database}/backupSchedules/{schedule}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scheduleId">The <c>Schedule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BackupScheduleName"/> with pattern
        /// <c>projects/{project}/instances/{instance}/databases/{database}/backupSchedules/{schedule}</c>.
        /// </returns>
        public static string FormatProjectInstanceDatabaseSchedule(string projectId, string instanceId, string databaseId, string scheduleId) =>
            s_projectInstanceDatabaseSchedule.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(databaseId, nameof(databaseId)), gax::GaxPreconditions.CheckNotNullOrEmpty(scheduleId, nameof(scheduleId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BackupScheduleName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/instances/{instance}/databases/{database}/backupSchedules/{schedule}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="backupScheduleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BackupScheduleName"/> if successful.</returns>
        public static BackupScheduleName Parse(string backupScheduleName) => Parse(backupScheduleName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BackupScheduleName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/instances/{instance}/databases/{database}/backupSchedules/{schedule}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="backupScheduleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="BackupScheduleName"/> if successful.</returns>
        public static BackupScheduleName Parse(string backupScheduleName, bool allowUnparsed) =>
            TryParse(backupScheduleName, allowUnparsed, out BackupScheduleName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BackupScheduleName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/instances/{instance}/databases/{database}/backupSchedules/{schedule}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="backupScheduleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BackupScheduleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string backupScheduleName, out BackupScheduleName result) =>
            TryParse(backupScheduleName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BackupScheduleName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/instances/{instance}/databases/{database}/backupSchedules/{schedule}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="backupScheduleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BackupScheduleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string backupScheduleName, bool allowUnparsed, out BackupScheduleName result)
        {
            gax::GaxPreconditions.CheckNotNull(backupScheduleName, nameof(backupScheduleName));
            gax::TemplatedResourceName resourceName;
            if (s_projectInstanceDatabaseSchedule.TryParseName(backupScheduleName, out resourceName))
            {
                result = FromProjectInstanceDatabaseSchedule(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(backupScheduleName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private BackupScheduleName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string databaseId = null, string instanceId = null, string projectId = null, string scheduleId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DatabaseId = databaseId;
            InstanceId = instanceId;
            ProjectId = projectId;
            ScheduleId = scheduleId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BackupScheduleName"/> class from the component parts of pattern
        /// <c>projects/{project}/instances/{instance}/databases/{database}/backupSchedules/{schedule}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scheduleId">The <c>Schedule</c> ID. Must not be <c>null</c> or empty.</param>
        public BackupScheduleName(string projectId, string instanceId, string databaseId, string scheduleId) : this(ResourceNameType.ProjectInstanceDatabaseSchedule, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), databaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(databaseId, nameof(databaseId)), scheduleId: gax::GaxPreconditions.CheckNotNullOrEmpty(scheduleId, nameof(scheduleId)))
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
        /// The <c>Schedule</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ScheduleId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectInstanceDatabaseSchedule: return s_projectInstanceDatabaseSchedule.Expand(ProjectId, InstanceId, DatabaseId, ScheduleId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as BackupScheduleName);

        /// <inheritdoc/>
        public bool Equals(BackupScheduleName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(BackupScheduleName a, BackupScheduleName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(BackupScheduleName a, BackupScheduleName b) => !(a == b);
    }

    public partial class BackupSchedule
    {
        /// <summary>
        /// <see cref="gcsadv::BackupScheduleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsadv::BackupScheduleName BackupScheduleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsadv::BackupScheduleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateBackupScheduleRequest
    {
        /// <summary>
        /// <see cref="DatabaseName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DatabaseName ParentAsDatabaseName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DatabaseName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetBackupScheduleRequest
    {
        /// <summary>
        /// <see cref="gcsadv::BackupScheduleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsadv::BackupScheduleName BackupScheduleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsadv::BackupScheduleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteBackupScheduleRequest
    {
        /// <summary>
        /// <see cref="gcsadv::BackupScheduleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsadv::BackupScheduleName BackupScheduleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsadv::BackupScheduleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListBackupSchedulesRequest
    {
        /// <summary>
        /// <see cref="DatabaseName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DatabaseName ParentAsDatabaseName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DatabaseName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
