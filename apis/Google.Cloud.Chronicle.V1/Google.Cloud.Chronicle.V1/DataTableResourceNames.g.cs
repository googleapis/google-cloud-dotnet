// Copyright 2026 Google LLC
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
using gccv = Google.Cloud.Chronicle.V1;
using sys = System;

namespace Google.Cloud.Chronicle.V1
{
    /// <summary>Resource name for the <c>DataTable</c> resource.</summary>
    public sealed partial class DataTableName : gax::IResourceName, sys::IEquatable<DataTableName>
    {
        /// <summary>The possible contents of <see cref="DataTableName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}</c>.
            /// </summary>
            ProjectLocationInstanceDataTable = 1,
        }

        private static gax::PathTemplate s_projectLocationInstanceDataTable = new gax::PathTemplate("projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}");

        /// <summary>Creates a <see cref="DataTableName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DataTableName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DataTableName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DataTableName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DataTableName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataTableId">The <c>DataTable</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DataTableName"/> constructed from the provided ids.</returns>
        public static DataTableName FromProjectLocationInstanceDataTable(string projectId, string locationId, string instanceId, string dataTableId) =>
            new DataTableName(ResourceNameType.ProjectLocationInstanceDataTable, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), dataTableId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataTableId, nameof(dataTableId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataTableName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataTableId">The <c>DataTable</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataTableName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string instanceId, string dataTableId) =>
            FormatProjectLocationInstanceDataTable(projectId, locationId, instanceId, dataTableId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataTableName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataTableId">The <c>DataTable</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataTableName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}</c>.
        /// </returns>
        public static string FormatProjectLocationInstanceDataTable(string projectId, string locationId, string instanceId, string dataTableId) =>
            s_projectLocationInstanceDataTable.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataTableId, nameof(dataTableId)));

        /// <summary>Parses the given resource name string into a new <see cref="DataTableName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataTableName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DataTableName"/> if successful.</returns>
        public static DataTableName Parse(string dataTableName) => Parse(dataTableName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataTableName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataTableName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DataTableName"/> if successful.</returns>
        public static DataTableName Parse(string dataTableName, bool allowUnparsed) =>
            TryParse(dataTableName, allowUnparsed, out DataTableName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataTableName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataTableName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataTableName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataTableName, out DataTableName result) => TryParse(dataTableName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataTableName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataTableName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataTableName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataTableName, bool allowUnparsed, out DataTableName result)
        {
            gax::GaxPreconditions.CheckNotNull(dataTableName, nameof(dataTableName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInstanceDataTable.TryParseName(dataTableName, out resourceName))
            {
                result = FromProjectLocationInstanceDataTable(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dataTableName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DataTableName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string dataTableId = null, string instanceId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DataTableId = dataTableId;
            InstanceId = instanceId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DataTableName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataTableId">The <c>DataTable</c> ID. Must not be <c>null</c> or empty.</param>
        public DataTableName(string projectId, string locationId, string instanceId, string dataTableId) : this(ResourceNameType.ProjectLocationInstanceDataTable, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), dataTableId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataTableId, nameof(dataTableId)))
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
        /// The <c>DataTable</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DataTableId { get; }

        /// <summary>
        /// The <c>Instance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string InstanceId { get; }

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
                case ResourceNameType.ProjectLocationInstanceDataTable: return s_projectLocationInstanceDataTable.Expand(ProjectId, LocationId, InstanceId, DataTableId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DataTableName);

        /// <inheritdoc/>
        public bool Equals(DataTableName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DataTableName a, DataTableName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DataTableName a, DataTableName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>DataTableRow</c> resource.</summary>
    public sealed partial class DataTableRowName : gax::IResourceName, sys::IEquatable<DataTableRowName>
    {
        /// <summary>The possible contents of <see cref="DataTableRowName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}/dataTableRows/{data_table_row}</c>
            /// .
            /// </summary>
            ProjectLocationInstanceDataTableDataTableRow = 1,
        }

        private static gax::PathTemplate s_projectLocationInstanceDataTableDataTableRow = new gax::PathTemplate("projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}/dataTableRows/{data_table_row}");

        /// <summary>Creates a <see cref="DataTableRowName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DataTableRowName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DataTableRowName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DataTableRowName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DataTableRowName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}/dataTableRows/{data_table_row}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataTableId">The <c>DataTable</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataTableRowId">The <c>DataTableRow</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DataTableRowName"/> constructed from the provided ids.</returns>
        public static DataTableRowName FromProjectLocationInstanceDataTableDataTableRow(string projectId, string locationId, string instanceId, string dataTableId, string dataTableRowId) =>
            new DataTableRowName(ResourceNameType.ProjectLocationInstanceDataTableDataTableRow, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), dataTableId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataTableId, nameof(dataTableId)), dataTableRowId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataTableRowId, nameof(dataTableRowId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataTableRowName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}/dataTableRows/{data_table_row}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataTableId">The <c>DataTable</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataTableRowId">The <c>DataTableRow</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataTableRowName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}/dataTableRows/{data_table_row}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string instanceId, string dataTableId, string dataTableRowId) =>
            FormatProjectLocationInstanceDataTableDataTableRow(projectId, locationId, instanceId, dataTableId, dataTableRowId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataTableRowName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}/dataTableRows/{data_table_row}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataTableId">The <c>DataTable</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataTableRowId">The <c>DataTableRow</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataTableRowName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}/dataTableRows/{data_table_row}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationInstanceDataTableDataTableRow(string projectId, string locationId, string instanceId, string dataTableId, string dataTableRowId) =>
            s_projectLocationInstanceDataTableDataTableRow.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataTableId, nameof(dataTableId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataTableRowId, nameof(dataTableRowId)));

        /// <summary>Parses the given resource name string into a new <see cref="DataTableRowName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}/dataTableRows/{data_table_row}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataTableRowName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DataTableRowName"/> if successful.</returns>
        public static DataTableRowName Parse(string dataTableRowName) => Parse(dataTableRowName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataTableRowName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}/dataTableRows/{data_table_row}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataTableRowName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DataTableRowName"/> if successful.</returns>
        public static DataTableRowName Parse(string dataTableRowName, bool allowUnparsed) =>
            TryParse(dataTableRowName, allowUnparsed, out DataTableRowName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataTableRowName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}/dataTableRows/{data_table_row}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataTableRowName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataTableRowName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataTableRowName, out DataTableRowName result) =>
            TryParse(dataTableRowName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataTableRowName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}/dataTableRows/{data_table_row}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataTableRowName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataTableRowName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataTableRowName, bool allowUnparsed, out DataTableRowName result)
        {
            gax::GaxPreconditions.CheckNotNull(dataTableRowName, nameof(dataTableRowName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInstanceDataTableDataTableRow.TryParseName(dataTableRowName, out resourceName))
            {
                result = FromProjectLocationInstanceDataTableDataTableRow(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dataTableRowName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DataTableRowName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string dataTableId = null, string dataTableRowId = null, string instanceId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DataTableId = dataTableId;
            DataTableRowId = dataTableRowId;
            InstanceId = instanceId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DataTableRowName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}/dataTableRows/{data_table_row}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataTableId">The <c>DataTable</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataTableRowId">The <c>DataTableRow</c> ID. Must not be <c>null</c> or empty.</param>
        public DataTableRowName(string projectId, string locationId, string instanceId, string dataTableId, string dataTableRowId) : this(ResourceNameType.ProjectLocationInstanceDataTableDataTableRow, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), dataTableId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataTableId, nameof(dataTableId)), dataTableRowId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataTableRowId, nameof(dataTableRowId)))
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
        /// The <c>DataTable</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DataTableId { get; }

        /// <summary>
        /// The <c>DataTableRow</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string DataTableRowId { get; }

        /// <summary>
        /// The <c>Instance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string InstanceId { get; }

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
                case ResourceNameType.ProjectLocationInstanceDataTableDataTableRow: return s_projectLocationInstanceDataTableDataTableRow.Expand(ProjectId, LocationId, InstanceId, DataTableId, DataTableRowId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DataTableRowName);

        /// <inheritdoc/>
        public bool Equals(DataTableRowName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DataTableRowName a, DataTableRowName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DataTableRowName a, DataTableRowName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>DataTableOperationErrors</c> resource.</summary>
    public sealed partial class DataTableOperationErrorsName : gax::IResourceName, sys::IEquatable<DataTableOperationErrorsName>
    {
        /// <summary>The possible contents of <see cref="DataTableOperationErrorsName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/instances/{instance}/dataTableOperationErrors/{data_table_operation_errors}</c>
            /// .
            /// </summary>
            ProjectLocationInstanceDataTableOperationErrors = 1,
        }

        private static gax::PathTemplate s_projectLocationInstanceDataTableOperationErrors = new gax::PathTemplate("projects/{project}/locations/{location}/instances/{instance}/dataTableOperationErrors/{data_table_operation_errors}");

        /// <summary>
        /// Creates a <see cref="DataTableOperationErrorsName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DataTableOperationErrorsName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DataTableOperationErrorsName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DataTableOperationErrorsName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DataTableOperationErrorsName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/dataTableOperationErrors/{data_table_operation_errors}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataTableOperationErrorsId">
        /// The <c>DataTableOperationErrors</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="DataTableOperationErrorsName"/> constructed from the provided ids.
        /// </returns>
        public static DataTableOperationErrorsName FromProjectLocationInstanceDataTableOperationErrors(string projectId, string locationId, string instanceId, string dataTableOperationErrorsId) =>
            new DataTableOperationErrorsName(ResourceNameType.ProjectLocationInstanceDataTableOperationErrors, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), dataTableOperationErrorsId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataTableOperationErrorsId, nameof(dataTableOperationErrorsId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataTableOperationErrorsName"/> with
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/dataTableOperationErrors/{data_table_operation_errors}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataTableOperationErrorsId">
        /// The <c>DataTableOperationErrors</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="DataTableOperationErrorsName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/dataTableOperationErrors/{data_table_operation_errors}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string instanceId, string dataTableOperationErrorsId) =>
            FormatProjectLocationInstanceDataTableOperationErrors(projectId, locationId, instanceId, dataTableOperationErrorsId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataTableOperationErrorsName"/> with
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/dataTableOperationErrors/{data_table_operation_errors}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataTableOperationErrorsId">
        /// The <c>DataTableOperationErrors</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="DataTableOperationErrorsName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/dataTableOperationErrors/{data_table_operation_errors}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationInstanceDataTableOperationErrors(string projectId, string locationId, string instanceId, string dataTableOperationErrorsId) =>
            s_projectLocationInstanceDataTableOperationErrors.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataTableOperationErrorsId, nameof(dataTableOperationErrorsId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataTableOperationErrorsName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/dataTableOperationErrors/{data_table_operation_errors}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataTableOperationErrorsName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="DataTableOperationErrorsName"/> if successful.</returns>
        public static DataTableOperationErrorsName Parse(string dataTableOperationErrorsName) =>
            Parse(dataTableOperationErrorsName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataTableOperationErrorsName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/dataTableOperationErrors/{data_table_operation_errors}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataTableOperationErrorsName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DataTableOperationErrorsName"/> if successful.</returns>
        public static DataTableOperationErrorsName Parse(string dataTableOperationErrorsName, bool allowUnparsed) =>
            TryParse(dataTableOperationErrorsName, allowUnparsed, out DataTableOperationErrorsName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataTableOperationErrorsName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/dataTableOperationErrors/{data_table_operation_errors}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataTableOperationErrorsName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataTableOperationErrorsName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataTableOperationErrorsName, out DataTableOperationErrorsName result) =>
            TryParse(dataTableOperationErrorsName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataTableOperationErrorsName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/dataTableOperationErrors/{data_table_operation_errors}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataTableOperationErrorsName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataTableOperationErrorsName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataTableOperationErrorsName, bool allowUnparsed, out DataTableOperationErrorsName result)
        {
            gax::GaxPreconditions.CheckNotNull(dataTableOperationErrorsName, nameof(dataTableOperationErrorsName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInstanceDataTableOperationErrors.TryParseName(dataTableOperationErrorsName, out resourceName))
            {
                result = FromProjectLocationInstanceDataTableOperationErrors(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dataTableOperationErrorsName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DataTableOperationErrorsName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string dataTableOperationErrorsId = null, string instanceId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DataTableOperationErrorsId = dataTableOperationErrorsId;
            InstanceId = instanceId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DataTableOperationErrorsName"/> class from the component parts of
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/dataTableOperationErrors/{data_table_operation_errors}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataTableOperationErrorsId">
        /// The <c>DataTableOperationErrors</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public DataTableOperationErrorsName(string projectId, string locationId, string instanceId, string dataTableOperationErrorsId) : this(ResourceNameType.ProjectLocationInstanceDataTableOperationErrors, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), dataTableOperationErrorsId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataTableOperationErrorsId, nameof(dataTableOperationErrorsId)))
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
        /// The <c>DataTableOperationErrors</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string DataTableOperationErrorsId { get; }

        /// <summary>
        /// The <c>Instance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string InstanceId { get; }

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
                case ResourceNameType.ProjectLocationInstanceDataTableOperationErrors: return s_projectLocationInstanceDataTableOperationErrors.Expand(ProjectId, LocationId, InstanceId, DataTableOperationErrorsId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DataTableOperationErrorsName);

        /// <inheritdoc/>
        public bool Equals(DataTableOperationErrorsName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DataTableOperationErrorsName a, DataTableOperationErrorsName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DataTableOperationErrorsName a, DataTableOperationErrorsName b) => !(a == b);
    }

    public partial class CreateDataTableRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetDataTableRequest
    {
        /// <summary>
        /// <see cref="gccv::DataTableName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::DataTableName DataTableName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::DataTableName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDataTablesRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteDataTableRequest
    {
        /// <summary>
        /// <see cref="gccv::DataTableName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::DataTableName DataTableName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::DataTableName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateDataTableRowRequest
    {
        /// <summary>
        /// <see cref="DataTableName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataTableName ParentAsDataTableName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataTableName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListDataTableRowsRequest
    {
        /// <summary>
        /// <see cref="DataTableName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataTableName ParentAsDataTableName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataTableName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetDataTableRowRequest
    {
        /// <summary>
        /// <see cref="gccv::DataTableRowName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::DataTableRowName DataTableRowName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::DataTableRowName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteDataTableRowRequest
    {
        /// <summary>
        /// <see cref="gccv::DataTableRowName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::DataTableRowName DataTableRowName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::DataTableRowName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class BulkCreateDataTableRowsRequest
    {
        /// <summary>
        /// <see cref="DataTableName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataTableName ParentAsDataTableName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataTableName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class BulkGetDataTableRowsRequest
    {
        /// <summary>
        /// <see cref="DataTableName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataTableName ParentAsDataTableName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataTableName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class BulkReplaceDataTableRowsRequest
    {
        /// <summary>
        /// <see cref="DataTableName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataTableName ParentAsDataTableName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataTableName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class BulkUpdateDataTableRowsRequest
    {
        /// <summary>
        /// <see cref="DataTableName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataTableName ParentAsDataTableName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataTableName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DataTableScopeInfo
    {
        /// <summary>
        /// <see cref="DataAccessScopeName"/>-typed view over the <see cref="DataAccessScopes"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<DataAccessScopeName> DataAccessScopesAsDataAccessScopeNames
        {
            get => new gax::ResourceNameList<DataAccessScopeName>(DataAccessScopes, s => string.IsNullOrEmpty(s) ? null : DataAccessScopeName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class DataTable
    {
        /// <summary>
        /// <see cref="gccv::DataTableName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::DataTableName DataTableName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::DataTableName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DataTableRow
    {
        /// <summary>
        /// <see cref="gccv::DataTableRowName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::DataTableRowName DataTableRowName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::DataTableRowName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetDataTableOperationErrorsRequest
    {
        /// <summary>
        /// <see cref="gccv::DataTableOperationErrorsName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gccv::DataTableOperationErrorsName DataTableOperationErrorsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::DataTableOperationErrorsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DataTableOperationErrors
    {
        /// <summary>
        /// <see cref="gccv::DataTableOperationErrorsName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gccv::DataTableOperationErrorsName DataTableOperationErrorsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::DataTableOperationErrorsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
