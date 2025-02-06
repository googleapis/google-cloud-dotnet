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
using gcnv = Google.Cloud.NetApp.V1;
using sys = System;

namespace Google.Cloud.NetApp.V1
{
    /// <summary>Resource name for the <c>Backup</c> resource.</summary>
    public sealed partial class BackupName : gax::IResourceName, sys::IEquatable<BackupName>
    {
        /// <summary>The possible contents of <see cref="BackupName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/backupVaults/{backup_vault}/backups/{backup}</c>.
            /// </summary>
            ProjectLocationBackupVaultBackup = 1,
        }

        private static gax::PathTemplate s_projectLocationBackupVaultBackup = new gax::PathTemplate("projects/{project}/locations/{location}/backupVaults/{backup_vault}/backups/{backup}");

        /// <summary>Creates a <see cref="BackupName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="BackupName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static BackupName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new BackupName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="BackupName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/backupVaults/{backup_vault}/backups/{backup}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupVaultId">The <c>BackupVault</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupId">The <c>Backup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="BackupName"/> constructed from the provided ids.</returns>
        public static BackupName FromProjectLocationBackupVaultBackup(string projectId, string locationId, string backupVaultId, string backupId) =>
            new BackupName(ResourceNameType.ProjectLocationBackupVaultBackup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), backupVaultId: gax::GaxPreconditions.CheckNotNullOrEmpty(backupVaultId, nameof(backupVaultId)), backupId: gax::GaxPreconditions.CheckNotNullOrEmpty(backupId, nameof(backupId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BackupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backupVaults/{backup_vault}/backups/{backup}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupVaultId">The <c>BackupVault</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupId">The <c>Backup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BackupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backupVaults/{backup_vault}/backups/{backup}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string backupVaultId, string backupId) =>
            FormatProjectLocationBackupVaultBackup(projectId, locationId, backupVaultId, backupId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BackupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backupVaults/{backup_vault}/backups/{backup}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupVaultId">The <c>BackupVault</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupId">The <c>Backup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BackupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backupVaults/{backup_vault}/backups/{backup}</c>.
        /// </returns>
        public static string FormatProjectLocationBackupVaultBackup(string projectId, string locationId, string backupVaultId, string backupId) =>
            s_projectLocationBackupVaultBackup.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(backupVaultId, nameof(backupVaultId)), gax::GaxPreconditions.CheckNotNullOrEmpty(backupId, nameof(backupId)));

        /// <summary>Parses the given resource name string into a new <see cref="BackupName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/backupVaults/{backup_vault}/backups/{backup}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="backupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BackupName"/> if successful.</returns>
        public static BackupName Parse(string backupName) => Parse(backupName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BackupName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/backupVaults/{backup_vault}/backups/{backup}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="backupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="BackupName"/> if successful.</returns>
        public static BackupName Parse(string backupName, bool allowUnparsed) =>
            TryParse(backupName, allowUnparsed, out BackupName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BackupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/backupVaults/{backup_vault}/backups/{backup}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="backupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BackupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string backupName, out BackupName result) => TryParse(backupName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BackupName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/backupVaults/{backup_vault}/backups/{backup}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="backupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BackupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string backupName, bool allowUnparsed, out BackupName result)
        {
            gax::GaxPreconditions.CheckNotNull(backupName, nameof(backupName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationBackupVaultBackup.TryParseName(backupName, out resourceName))
            {
                result = FromProjectLocationBackupVaultBackup(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(backupName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private BackupName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string backupId = null, string backupVaultId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BackupId = backupId;
            BackupVaultId = backupVaultId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BackupName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/backupVaults/{backup_vault}/backups/{backup}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupVaultId">The <c>BackupVault</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupId">The <c>Backup</c> ID. Must not be <c>null</c> or empty.</param>
        public BackupName(string projectId, string locationId, string backupVaultId, string backupId) : this(ResourceNameType.ProjectLocationBackupVaultBackup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), backupVaultId: gax::GaxPreconditions.CheckNotNullOrEmpty(backupVaultId, nameof(backupVaultId)), backupId: gax::GaxPreconditions.CheckNotNullOrEmpty(backupId, nameof(backupId)))
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
        /// The <c>BackupVault</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string BackupVaultId { get; }

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
                case ResourceNameType.ProjectLocationBackupVaultBackup: return s_projectLocationBackupVaultBackup.Expand(ProjectId, LocationId, BackupVaultId, BackupId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as BackupName);

        /// <inheritdoc/>
        public bool Equals(BackupName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(BackupName a, BackupName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(BackupName a, BackupName b) => !(a == b);
    }

    public partial class Backup
    {
        /// <summary>
        /// <see cref="gcnv::BackupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::BackupName BackupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::BackupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="VolumeName"/>-typed view over the <see cref="SourceVolume"/> resource name property.
        /// </summary>
        public VolumeName SourceVolumeAsVolumeName
        {
            get => string.IsNullOrEmpty(SourceVolume) ? null : VolumeName.Parse(SourceVolume, allowUnparsed: true);
            set => SourceVolume = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SnapshotName"/>-typed view over the <see cref="SourceSnapshot"/> resource name property.
        /// </summary>
        public SnapshotName SourceSnapshotAsSnapshotName
        {
            get => string.IsNullOrEmpty(SourceSnapshot) ? null : SnapshotName.Parse(SourceSnapshot, allowUnparsed: true);
            set => SourceSnapshot = value?.ToString() ?? "";
        }
    }

    public partial class ListBackupsRequest
    {
        /// <summary>
        /// <see cref="BackupVaultName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public BackupVaultName ParentAsBackupVaultName
        {
            get => string.IsNullOrEmpty(Parent) ? null : BackupVaultName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetBackupRequest
    {
        /// <summary>
        /// <see cref="gcnv::BackupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::BackupName BackupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::BackupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateBackupRequest
    {
        /// <summary>
        /// <see cref="BackupVaultName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public BackupVaultName ParentAsBackupVaultName
        {
            get => string.IsNullOrEmpty(Parent) ? null : BackupVaultName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteBackupRequest
    {
        /// <summary>
        /// <see cref="gcnv::BackupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::BackupName BackupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::BackupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
