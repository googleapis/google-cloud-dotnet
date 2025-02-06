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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcbv = Google.Cloud.BackupDR.V1;
using sys = System;

namespace Google.Cloud.BackupDR.V1
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
            /// A resource name with pattern <c>projects/{project}/locations/{location}/backupVaults/{backupvault}</c>.
            /// </summary>
            ProjectLocationBackupvault = 1,
        }

        private static gax::PathTemplate s_projectLocationBackupvault = new gax::PathTemplate("projects/{project}/locations/{location}/backupVaults/{backupvault}");

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
        /// <c>projects/{project}/locations/{location}/backupVaults/{backupvault}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupvaultId">The <c>Backupvault</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="BackupVaultName"/> constructed from the provided ids.</returns>
        public static BackupVaultName FromProjectLocationBackupvault(string projectId, string locationId, string backupvaultId) =>
            new BackupVaultName(ResourceNameType.ProjectLocationBackupvault, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), backupvaultId: gax::GaxPreconditions.CheckNotNullOrEmpty(backupvaultId, nameof(backupvaultId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BackupVaultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backupVaults/{backupvault}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupvaultId">The <c>Backupvault</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BackupVaultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backupVaults/{backupvault}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string backupvaultId) =>
            FormatProjectLocationBackupvault(projectId, locationId, backupvaultId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BackupVaultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backupVaults/{backupvault}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupvaultId">The <c>Backupvault</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BackupVaultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backupVaults/{backupvault}</c>.
        /// </returns>
        public static string FormatProjectLocationBackupvault(string projectId, string locationId, string backupvaultId) =>
            s_projectLocationBackupvault.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(backupvaultId, nameof(backupvaultId)));

        /// <summary>Parses the given resource name string into a new <see cref="BackupVaultName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/backupVaults/{backupvault}</c></description>
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
        /// <description><c>projects/{project}/locations/{location}/backupVaults/{backupvault}</c></description>
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
        /// <description><c>projects/{project}/locations/{location}/backupVaults/{backupvault}</c></description>
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
        /// <description><c>projects/{project}/locations/{location}/backupVaults/{backupvault}</c></description>
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
            if (s_projectLocationBackupvault.TryParseName(backupVaultName, out resourceName))
            {
                result = FromProjectLocationBackupvault(resourceName[0], resourceName[1], resourceName[2]);
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

        private BackupVaultName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string backupvaultId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BackupvaultId = backupvaultId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BackupVaultName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/backupVaults/{backupvault}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupvaultId">The <c>Backupvault</c> ID. Must not be <c>null</c> or empty.</param>
        public BackupVaultName(string projectId, string locationId, string backupvaultId) : this(ResourceNameType.ProjectLocationBackupvault, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), backupvaultId: gax::GaxPreconditions.CheckNotNullOrEmpty(backupvaultId, nameof(backupvaultId)))
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
        /// The <c>Backupvault</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string BackupvaultId { get; }

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
                case ResourceNameType.ProjectLocationBackupvault: return s_projectLocationBackupvault.Expand(ProjectId, LocationId, BackupvaultId);
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

    /// <summary>Resource name for the <c>DataSource</c> resource.</summary>
    public sealed partial class DataSourceName : gax::IResourceName, sys::IEquatable<DataSourceName>
    {
        /// <summary>The possible contents of <see cref="DataSourceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}</c>.
            /// </summary>
            ProjectLocationBackupvaultDatasource = 1,
        }

        private static gax::PathTemplate s_projectLocationBackupvaultDatasource = new gax::PathTemplate("projects/{project}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}");

        /// <summary>Creates a <see cref="DataSourceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DataSourceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DataSourceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DataSourceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DataSourceName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupvaultId">The <c>Backupvault</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasourceId">The <c>Datasource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DataSourceName"/> constructed from the provided ids.</returns>
        public static DataSourceName FromProjectLocationBackupvaultDatasource(string projectId, string locationId, string backupvaultId, string datasourceId) =>
            new DataSourceName(ResourceNameType.ProjectLocationBackupvaultDatasource, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), backupvaultId: gax::GaxPreconditions.CheckNotNullOrEmpty(backupvaultId, nameof(backupvaultId)), datasourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasourceId, nameof(datasourceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataSourceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupvaultId">The <c>Backupvault</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasourceId">The <c>Datasource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataSourceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string backupvaultId, string datasourceId) =>
            FormatProjectLocationBackupvaultDatasource(projectId, locationId, backupvaultId, datasourceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataSourceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupvaultId">The <c>Backupvault</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasourceId">The <c>Datasource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataSourceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}</c>.
        /// </returns>
        public static string FormatProjectLocationBackupvaultDatasource(string projectId, string locationId, string backupvaultId, string datasourceId) =>
            s_projectLocationBackupvaultDatasource.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(backupvaultId, nameof(backupvaultId)), gax::GaxPreconditions.CheckNotNullOrEmpty(datasourceId, nameof(datasourceId)));

        /// <summary>Parses the given resource name string into a new <see cref="DataSourceName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataSourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DataSourceName"/> if successful.</returns>
        public static DataSourceName Parse(string dataSourceName) => Parse(dataSourceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataSourceName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataSourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DataSourceName"/> if successful.</returns>
        public static DataSourceName Parse(string dataSourceName, bool allowUnparsed) =>
            TryParse(dataSourceName, allowUnparsed, out DataSourceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataSourceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataSourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataSourceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataSourceName, out DataSourceName result) =>
            TryParse(dataSourceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataSourceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataSourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataSourceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataSourceName, bool allowUnparsed, out DataSourceName result)
        {
            gax::GaxPreconditions.CheckNotNull(dataSourceName, nameof(dataSourceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationBackupvaultDatasource.TryParseName(dataSourceName, out resourceName))
            {
                result = FromProjectLocationBackupvaultDatasource(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dataSourceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DataSourceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string backupvaultId = null, string datasourceId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BackupvaultId = backupvaultId;
            DatasourceId = datasourceId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DataSourceName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupvaultId">The <c>Backupvault</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasourceId">The <c>Datasource</c> ID. Must not be <c>null</c> or empty.</param>
        public DataSourceName(string projectId, string locationId, string backupvaultId, string datasourceId) : this(ResourceNameType.ProjectLocationBackupvaultDatasource, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), backupvaultId: gax::GaxPreconditions.CheckNotNullOrEmpty(backupvaultId, nameof(backupvaultId)), datasourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasourceId, nameof(datasourceId)))
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
        /// The <c>Backupvault</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string BackupvaultId { get; }

        /// <summary>
        /// The <c>Datasource</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DatasourceId { get; }

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
                case ResourceNameType.ProjectLocationBackupvaultDatasource: return s_projectLocationBackupvaultDatasource.Expand(ProjectId, LocationId, BackupvaultId, DatasourceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DataSourceName);

        /// <inheritdoc/>
        public bool Equals(DataSourceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DataSourceName a, DataSourceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DataSourceName a, DataSourceName b) => !(a == b);
    }

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
            /// <c>
            /// projects/{project}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}/backups/{backup}</c>
            /// .
            /// </summary>
            ProjectLocationBackupvaultDatasourceBackup = 1,
        }

        private static gax::PathTemplate s_projectLocationBackupvaultDatasourceBackup = new gax::PathTemplate("projects/{project}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}/backups/{backup}");

        /// <summary>Creates a <see cref="BackupName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="BackupName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static BackupName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new BackupName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="BackupName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}/backups/{backup}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupvaultId">The <c>Backupvault</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasourceId">The <c>Datasource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupId">The <c>Backup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="BackupName"/> constructed from the provided ids.</returns>
        public static BackupName FromProjectLocationBackupvaultDatasourceBackup(string projectId, string locationId, string backupvaultId, string datasourceId, string backupId) =>
            new BackupName(ResourceNameType.ProjectLocationBackupvaultDatasourceBackup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), backupvaultId: gax::GaxPreconditions.CheckNotNullOrEmpty(backupvaultId, nameof(backupvaultId)), datasourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasourceId, nameof(datasourceId)), backupId: gax::GaxPreconditions.CheckNotNullOrEmpty(backupId, nameof(backupId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BackupName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}/backups/{backup}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupvaultId">The <c>Backupvault</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasourceId">The <c>Datasource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupId">The <c>Backup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BackupName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}/backups/{backup}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string backupvaultId, string datasourceId, string backupId) =>
            FormatProjectLocationBackupvaultDatasourceBackup(projectId, locationId, backupvaultId, datasourceId, backupId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BackupName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}/backups/{backup}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupvaultId">The <c>Backupvault</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasourceId">The <c>Datasource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupId">The <c>Backup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BackupName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}/backups/{backup}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationBackupvaultDatasourceBackup(string projectId, string locationId, string backupvaultId, string datasourceId, string backupId) =>
            s_projectLocationBackupvaultDatasourceBackup.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(backupvaultId, nameof(backupvaultId)), gax::GaxPreconditions.CheckNotNullOrEmpty(datasourceId, nameof(datasourceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(backupId, nameof(backupId)));

        /// <summary>Parses the given resource name string into a new <see cref="BackupName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}/backups/{backup}</c>
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
        /// <c>
        /// projects/{project}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}/backups/{backup}</c>
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
        /// <c>
        /// projects/{project}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}/backups/{backup}</c>
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
        /// <c>
        /// projects/{project}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}/backups/{backup}</c>
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
            if (s_projectLocationBackupvaultDatasourceBackup.TryParseName(backupName, out resourceName))
            {
                result = FromProjectLocationBackupvaultDatasourceBackup(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
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

        private BackupName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string backupId = null, string backupvaultId = null, string datasourceId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BackupId = backupId;
            BackupvaultId = backupvaultId;
            DatasourceId = datasourceId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BackupName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}/backups/{backup}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupvaultId">The <c>Backupvault</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasourceId">The <c>Datasource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupId">The <c>Backup</c> ID. Must not be <c>null</c> or empty.</param>
        public BackupName(string projectId, string locationId, string backupvaultId, string datasourceId, string backupId) : this(ResourceNameType.ProjectLocationBackupvaultDatasourceBackup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), backupvaultId: gax::GaxPreconditions.CheckNotNullOrEmpty(backupvaultId, nameof(backupvaultId)), datasourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasourceId, nameof(datasourceId)), backupId: gax::GaxPreconditions.CheckNotNullOrEmpty(backupId, nameof(backupId)))
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
        /// The <c>Backupvault</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string BackupvaultId { get; }

        /// <summary>
        /// The <c>Datasource</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DatasourceId { get; }

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
                case ResourceNameType.ProjectLocationBackupvaultDatasourceBackup: return s_projectLocationBackupvaultDatasourceBackup.Expand(ProjectId, LocationId, BackupvaultId, DatasourceId, BackupId);
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

    public partial class BackupVault
    {
        /// <summary>
        /// <see cref="gcbv::BackupVaultName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::BackupVaultName BackupVaultName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::BackupVaultName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DataSource
    {
        /// <summary>
        /// <see cref="gcbv::DataSourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::DataSourceName DataSourceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::DataSourceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GcpBackupConfig
    {
        /// <summary>
        /// <see cref="BackupPlanName"/>-typed view over the <see cref="BackupPlan"/> resource name property.
        /// </summary>
        public BackupPlanName BackupPlanAsBackupPlanName
        {
            get => string.IsNullOrEmpty(BackupPlan) ? null : BackupPlanName.Parse(BackupPlan, allowUnparsed: true);
            set => BackupPlan = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="BackupPlanAssociationName"/>-typed view over the <see cref="BackupPlanAssociation"/> resource
        /// name property.
        /// </summary>
        public BackupPlanAssociationName BackupPlanAssociationAsBackupPlanAssociationName
        {
            get => string.IsNullOrEmpty(BackupPlanAssociation) ? null : BackupPlanAssociationName.Parse(BackupPlanAssociation, allowUnparsed: true);
            set => BackupPlanAssociation = value?.ToString() ?? "";
        }
    }

    public partial class Backup
    {
        /// <summary>
        /// <see cref="gcbv::BackupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::BackupName BackupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::BackupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class GCPBackupPlanInfo
            {
                /// <summary>
                /// <see cref="BackupPlanName"/>-typed view over the <see cref="BackupPlan"/> resource name property.
                /// </summary>
                public BackupPlanName BackupPlanAsBackupPlanName
                {
                    get => string.IsNullOrEmpty(BackupPlan) ? null : BackupPlanName.Parse(BackupPlan, allowUnparsed: true);
                    set => BackupPlan = value?.ToString() ?? "";
                }
            }
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

    public partial class FetchUsableBackupVaultsRequest
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

    public partial class GetBackupVaultRequest
    {
        /// <summary>
        /// <see cref="gcbv::BackupVaultName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::BackupVaultName BackupVaultName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::BackupVaultName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteBackupVaultRequest
    {
        /// <summary>
        /// <see cref="gcbv::BackupVaultName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::BackupVaultName BackupVaultName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::BackupVaultName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDataSourcesRequest
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

    public partial class GetDataSourceRequest
    {
        /// <summary>
        /// <see cref="gcbv::DataSourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::DataSourceName DataSourceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::DataSourceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListBackupsRequest
    {
        /// <summary>
        /// <see cref="DataSourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataSourceName ParentAsDataSourceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataSourceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetBackupRequest
    {
        /// <summary>
        /// <see cref="gcbv::BackupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::BackupName BackupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::BackupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteBackupRequest
    {
        /// <summary>
        /// <see cref="gcbv::BackupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::BackupName BackupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::BackupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RestoreBackupRequest
    {
        /// <summary>
        /// <see cref="gcbv::BackupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::BackupName BackupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::BackupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
