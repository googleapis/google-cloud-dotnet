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
    /// <summary>Resource name for the <c>BackupVault</c> resource.</summary>
    public sealed partial class BackupVaultName : gax::IResourceName, sys::IEquatable<BackupVaultName>
    {
        /// <summary>The possible contents of <see cref="BackupVaultName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/backupVaults/{backup_vault}</c>.
            /// </summary>
            ProjectLocationBackupVault = 1,
        }

        private static gax::PathTemplate s_projectLocationBackupVault = new gax::PathTemplate("projects/{project}/locations/{location}/backupVaults/{backup_vault}");

        /// <summary>Creates a <see cref="BackupVaultName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="BackupVaultName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static BackupVaultName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new BackupVaultName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="BackupVaultName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/backupVaults/{backup_vault}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupVaultId">The <c>BackupVault</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="BackupVaultName"/> constructed from the provided ids.</returns>
        public static BackupVaultName FromProjectLocationBackupVault(string projectId, string locationId, string backupVaultId) =>
            new BackupVaultName(ResourceNameType.ProjectLocationBackupVault, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), backupVaultId: gax::GaxPreconditions.CheckNotNullOrEmpty(backupVaultId, nameof(backupVaultId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BackupVaultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backupVaults/{backup_vault}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupVaultId">The <c>BackupVault</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BackupVaultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backupVaults/{backup_vault}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string backupVaultId) =>
            FormatProjectLocationBackupVault(projectId, locationId, backupVaultId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BackupVaultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backupVaults/{backup_vault}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupVaultId">The <c>BackupVault</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BackupVaultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backupVaults/{backup_vault}</c>.
        /// </returns>
        public static string FormatProjectLocationBackupVault(string projectId, string locationId, string backupVaultId) =>
            s_projectLocationBackupVault.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(backupVaultId, nameof(backupVaultId)));

        /// <summary>Parses the given resource name string into a new <see cref="BackupVaultName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/backupVaults/{backup_vault}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="backupVaultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BackupVaultName"/> if successful.</returns>
        public static BackupVaultName Parse(string backupVaultName) => Parse(backupVaultName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BackupVaultName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/backupVaults/{backup_vault}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="backupVaultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="BackupVaultName"/> if successful.</returns>
        public static BackupVaultName Parse(string backupVaultName, bool allowUnparsed) =>
            TryParse(backupVaultName, allowUnparsed, out BackupVaultName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BackupVaultName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/backupVaults/{backup_vault}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="backupVaultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BackupVaultName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string backupVaultName, out BackupVaultName result) =>
            TryParse(backupVaultName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BackupVaultName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/backupVaults/{backup_vault}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="backupVaultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BackupVaultName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string backupVaultName, bool allowUnparsed, out BackupVaultName result)
        {
            gax::GaxPreconditions.CheckNotNull(backupVaultName, nameof(backupVaultName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationBackupVault.TryParseName(backupVaultName, out resourceName))
            {
                result = FromProjectLocationBackupVault(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(backupVaultName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private BackupVaultName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string backupVaultId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BackupVaultId = backupVaultId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BackupVaultName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/backupVaults/{backup_vault}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupVaultId">The <c>BackupVault</c> ID. Must not be <c>null</c> or empty.</param>
        public BackupVaultName(string projectId, string locationId, string backupVaultId) : this(ResourceNameType.ProjectLocationBackupVault, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), backupVaultId: gax::GaxPreconditions.CheckNotNullOrEmpty(backupVaultId, nameof(backupVaultId)))
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
                case ResourceNameType.ProjectLocationBackupVault: return s_projectLocationBackupVault.Expand(ProjectId, LocationId, BackupVaultId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as BackupVaultName);

        /// <inheritdoc/>
        public bool Equals(BackupVaultName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(BackupVaultName a, BackupVaultName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(BackupVaultName a, BackupVaultName b) => !(a == b);
    }

    public partial class BackupVault
    {
        /// <summary>
        /// <see cref="gcnv::BackupVaultName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::BackupVaultName BackupVaultName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::BackupVaultName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetBackupVaultRequest
    {
        /// <summary>
        /// <see cref="gcnv::BackupVaultName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::BackupVaultName BackupVaultName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::BackupVaultName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListBackupVaultsRequest
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

    public partial class CreateBackupVaultRequest
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

    public partial class DeleteBackupVaultRequest
    {
        /// <summary>
        /// <see cref="gcnv::BackupVaultName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::BackupVaultName BackupVaultName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::BackupVaultName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
