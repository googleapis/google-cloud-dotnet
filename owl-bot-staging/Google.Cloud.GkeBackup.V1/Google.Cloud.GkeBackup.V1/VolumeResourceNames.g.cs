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
using gcgv = Google.Cloud.GkeBackup.V1;
using sys = System;

namespace Google.Cloud.GkeBackup.V1
{
    /// <summary>Resource name for the <c>VolumeBackup</c> resource.</summary>
    public sealed partial class VolumeBackupName : gax::IResourceName, sys::IEquatable<VolumeBackupName>
    {
        /// <summary>The possible contents of <see cref="VolumeBackupName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/backupPlans/{backup_plan}/backups/{backup}/volumeBackups/{volume_backup}</c>
            /// .
            /// </summary>
            ProjectLocationBackupPlanBackupVolumeBackup = 1,
        }

        private static gax::PathTemplate s_projectLocationBackupPlanBackupVolumeBackup = new gax::PathTemplate("projects/{project}/locations/{location}/backupPlans/{backup_plan}/backups/{backup}/volumeBackups/{volume_backup}");

        /// <summary>Creates a <see cref="VolumeBackupName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="VolumeBackupName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static VolumeBackupName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new VolumeBackupName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="VolumeBackupName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/backupPlans/{backup_plan}/backups/{backup}/volumeBackups/{volume_backup}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupPlanId">The <c>BackupPlan</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupId">The <c>Backup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeBackupId">The <c>VolumeBackup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="VolumeBackupName"/> constructed from the provided ids.</returns>
        public static VolumeBackupName FromProjectLocationBackupPlanBackupVolumeBackup(string projectId, string locationId, string backupPlanId, string backupId, string volumeBackupId) =>
            new VolumeBackupName(ResourceNameType.ProjectLocationBackupPlanBackupVolumeBackup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), backupPlanId: gax::GaxPreconditions.CheckNotNullOrEmpty(backupPlanId, nameof(backupPlanId)), backupId: gax::GaxPreconditions.CheckNotNullOrEmpty(backupId, nameof(backupId)), volumeBackupId: gax::GaxPreconditions.CheckNotNullOrEmpty(volumeBackupId, nameof(volumeBackupId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="VolumeBackupName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/backupPlans/{backup_plan}/backups/{backup}/volumeBackups/{volume_backup}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupPlanId">The <c>BackupPlan</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupId">The <c>Backup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeBackupId">The <c>VolumeBackup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="VolumeBackupName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/backupPlans/{backup_plan}/backups/{backup}/volumeBackups/{volume_backup}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string backupPlanId, string backupId, string volumeBackupId) =>
            FormatProjectLocationBackupPlanBackupVolumeBackup(projectId, locationId, backupPlanId, backupId, volumeBackupId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="VolumeBackupName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/backupPlans/{backup_plan}/backups/{backup}/volumeBackups/{volume_backup}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupPlanId">The <c>BackupPlan</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupId">The <c>Backup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeBackupId">The <c>VolumeBackup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="VolumeBackupName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/backupPlans/{backup_plan}/backups/{backup}/volumeBackups/{volume_backup}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationBackupPlanBackupVolumeBackup(string projectId, string locationId, string backupPlanId, string backupId, string volumeBackupId) =>
            s_projectLocationBackupPlanBackupVolumeBackup.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(backupPlanId, nameof(backupPlanId)), gax::GaxPreconditions.CheckNotNullOrEmpty(backupId, nameof(backupId)), gax::GaxPreconditions.CheckNotNullOrEmpty(volumeBackupId, nameof(volumeBackupId)));

        /// <summary>Parses the given resource name string into a new <see cref="VolumeBackupName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/backupPlans/{backup_plan}/backups/{backup}/volumeBackups/{volume_backup}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="volumeBackupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="VolumeBackupName"/> if successful.</returns>
        public static VolumeBackupName Parse(string volumeBackupName) => Parse(volumeBackupName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="VolumeBackupName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/backupPlans/{backup_plan}/backups/{backup}/volumeBackups/{volume_backup}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="volumeBackupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="VolumeBackupName"/> if successful.</returns>
        public static VolumeBackupName Parse(string volumeBackupName, bool allowUnparsed) =>
            TryParse(volumeBackupName, allowUnparsed, out VolumeBackupName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="VolumeBackupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/backupPlans/{backup_plan}/backups/{backup}/volumeBackups/{volume_backup}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="volumeBackupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="VolumeBackupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string volumeBackupName, out VolumeBackupName result) =>
            TryParse(volumeBackupName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="VolumeBackupName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/backupPlans/{backup_plan}/backups/{backup}/volumeBackups/{volume_backup}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="volumeBackupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="VolumeBackupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string volumeBackupName, bool allowUnparsed, out VolumeBackupName result)
        {
            gax::GaxPreconditions.CheckNotNull(volumeBackupName, nameof(volumeBackupName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationBackupPlanBackupVolumeBackup.TryParseName(volumeBackupName, out resourceName))
            {
                result = FromProjectLocationBackupPlanBackupVolumeBackup(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(volumeBackupName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private VolumeBackupName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string backupId = null, string backupPlanId = null, string locationId = null, string projectId = null, string volumeBackupId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BackupId = backupId;
            BackupPlanId = backupPlanId;
            LocationId = locationId;
            ProjectId = projectId;
            VolumeBackupId = volumeBackupId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="VolumeBackupName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/backupPlans/{backup_plan}/backups/{backup}/volumeBackups/{volume_backup}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupPlanId">The <c>BackupPlan</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupId">The <c>Backup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeBackupId">The <c>VolumeBackup</c> ID. Must not be <c>null</c> or empty.</param>
        public VolumeBackupName(string projectId, string locationId, string backupPlanId, string backupId, string volumeBackupId) : this(ResourceNameType.ProjectLocationBackupPlanBackupVolumeBackup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), backupPlanId: gax::GaxPreconditions.CheckNotNullOrEmpty(backupPlanId, nameof(backupPlanId)), backupId: gax::GaxPreconditions.CheckNotNullOrEmpty(backupId, nameof(backupId)), volumeBackupId: gax::GaxPreconditions.CheckNotNullOrEmpty(volumeBackupId, nameof(volumeBackupId)))
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
        /// The <c>Backup</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string BackupId { get; }

        /// <summary>
        /// The <c>BackupPlan</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string BackupPlanId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>VolumeBackup</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string VolumeBackupId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationBackupPlanBackupVolumeBackup: return s_projectLocationBackupPlanBackupVolumeBackup.Expand(ProjectId, LocationId, BackupPlanId, BackupId, VolumeBackupId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as VolumeBackupName);

        /// <inheritdoc/>
        public bool Equals(VolumeBackupName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(VolumeBackupName a, VolumeBackupName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(VolumeBackupName a, VolumeBackupName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>VolumeRestore</c> resource.</summary>
    public sealed partial class VolumeRestoreName : gax::IResourceName, sys::IEquatable<VolumeRestoreName>
    {
        /// <summary>The possible contents of <see cref="VolumeRestoreName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/restorePlans/{restore_plan}/restores/{restore}/volumeRestores/{volume_restore}</c>
            /// .
            /// </summary>
            ProjectLocationRestorePlanRestoreVolumeRestore = 1,
        }

        private static gax::PathTemplate s_projectLocationRestorePlanRestoreVolumeRestore = new gax::PathTemplate("projects/{project}/locations/{location}/restorePlans/{restore_plan}/restores/{restore}/volumeRestores/{volume_restore}");

        /// <summary>Creates a <see cref="VolumeRestoreName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="VolumeRestoreName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static VolumeRestoreName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new VolumeRestoreName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="VolumeRestoreName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/restorePlans/{restore_plan}/restores/{restore}/volumeRestores/{volume_restore}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restorePlanId">The <c>RestorePlan</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restoreId">The <c>Restore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeRestoreId">The <c>VolumeRestore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="VolumeRestoreName"/> constructed from the provided ids.</returns>
        public static VolumeRestoreName FromProjectLocationRestorePlanRestoreVolumeRestore(string projectId, string locationId, string restorePlanId, string restoreId, string volumeRestoreId) =>
            new VolumeRestoreName(ResourceNameType.ProjectLocationRestorePlanRestoreVolumeRestore, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), restorePlanId: gax::GaxPreconditions.CheckNotNullOrEmpty(restorePlanId, nameof(restorePlanId)), restoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(restoreId, nameof(restoreId)), volumeRestoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(volumeRestoreId, nameof(volumeRestoreId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="VolumeRestoreName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/restorePlans/{restore_plan}/restores/{restore}/volumeRestores/{volume_restore}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restorePlanId">The <c>RestorePlan</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restoreId">The <c>Restore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeRestoreId">The <c>VolumeRestore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="VolumeRestoreName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/restorePlans/{restore_plan}/restores/{restore}/volumeRestores/{volume_restore}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string restorePlanId, string restoreId, string volumeRestoreId) =>
            FormatProjectLocationRestorePlanRestoreVolumeRestore(projectId, locationId, restorePlanId, restoreId, volumeRestoreId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="VolumeRestoreName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/restorePlans/{restore_plan}/restores/{restore}/volumeRestores/{volume_restore}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restorePlanId">The <c>RestorePlan</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restoreId">The <c>Restore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeRestoreId">The <c>VolumeRestore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="VolumeRestoreName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/restorePlans/{restore_plan}/restores/{restore}/volumeRestores/{volume_restore}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationRestorePlanRestoreVolumeRestore(string projectId, string locationId, string restorePlanId, string restoreId, string volumeRestoreId) =>
            s_projectLocationRestorePlanRestoreVolumeRestore.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(restorePlanId, nameof(restorePlanId)), gax::GaxPreconditions.CheckNotNullOrEmpty(restoreId, nameof(restoreId)), gax::GaxPreconditions.CheckNotNullOrEmpty(volumeRestoreId, nameof(volumeRestoreId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="VolumeRestoreName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/restorePlans/{restore_plan}/restores/{restore}/volumeRestores/{volume_restore}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="volumeRestoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="VolumeRestoreName"/> if successful.</returns>
        public static VolumeRestoreName Parse(string volumeRestoreName) => Parse(volumeRestoreName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="VolumeRestoreName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/restorePlans/{restore_plan}/restores/{restore}/volumeRestores/{volume_restore}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="volumeRestoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="VolumeRestoreName"/> if successful.</returns>
        public static VolumeRestoreName Parse(string volumeRestoreName, bool allowUnparsed) =>
            TryParse(volumeRestoreName, allowUnparsed, out VolumeRestoreName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="VolumeRestoreName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/restorePlans/{restore_plan}/restores/{restore}/volumeRestores/{volume_restore}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="volumeRestoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="VolumeRestoreName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string volumeRestoreName, out VolumeRestoreName result) =>
            TryParse(volumeRestoreName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="VolumeRestoreName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/restorePlans/{restore_plan}/restores/{restore}/volumeRestores/{volume_restore}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="volumeRestoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="VolumeRestoreName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string volumeRestoreName, bool allowUnparsed, out VolumeRestoreName result)
        {
            gax::GaxPreconditions.CheckNotNull(volumeRestoreName, nameof(volumeRestoreName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRestorePlanRestoreVolumeRestore.TryParseName(volumeRestoreName, out resourceName))
            {
                result = FromProjectLocationRestorePlanRestoreVolumeRestore(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(volumeRestoreName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private VolumeRestoreName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string restoreId = null, string restorePlanId = null, string volumeRestoreId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            RestoreId = restoreId;
            RestorePlanId = restorePlanId;
            VolumeRestoreId = volumeRestoreId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="VolumeRestoreName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/restorePlans/{restore_plan}/restores/{restore}/volumeRestores/{volume_restore}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restorePlanId">The <c>RestorePlan</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restoreId">The <c>Restore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeRestoreId">The <c>VolumeRestore</c> ID. Must not be <c>null</c> or empty.</param>
        public VolumeRestoreName(string projectId, string locationId, string restorePlanId, string restoreId, string volumeRestoreId) : this(ResourceNameType.ProjectLocationRestorePlanRestoreVolumeRestore, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), restorePlanId: gax::GaxPreconditions.CheckNotNullOrEmpty(restorePlanId, nameof(restorePlanId)), restoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(restoreId, nameof(restoreId)), volumeRestoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(volumeRestoreId, nameof(volumeRestoreId)))
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
        /// The <c>Restore</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RestoreId { get; }

        /// <summary>
        /// The <c>RestorePlan</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RestorePlanId { get; }

        /// <summary>
        /// The <c>VolumeRestore</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string VolumeRestoreId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationRestorePlanRestoreVolumeRestore: return s_projectLocationRestorePlanRestoreVolumeRestore.Expand(ProjectId, LocationId, RestorePlanId, RestoreId, VolumeRestoreId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as VolumeRestoreName);

        /// <inheritdoc/>
        public bool Equals(VolumeRestoreName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(VolumeRestoreName a, VolumeRestoreName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(VolumeRestoreName a, VolumeRestoreName b) => !(a == b);
    }

    public partial class VolumeBackup
    {
        /// <summary>
        /// <see cref="gcgv::VolumeBackupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::VolumeBackupName VolumeBackupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::VolumeBackupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class VolumeRestore
    {
        /// <summary>
        /// <see cref="gcgv::VolumeRestoreName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::VolumeRestoreName VolumeRestoreName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::VolumeRestoreName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
