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
using gatv = Google.Area120.Tables.V1Alpha1;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Area120.Tables.V1Alpha1
{
    /// <summary>Resource name for the <c>Table</c> resource.</summary>
    public sealed partial class TableName : gax::IResourceName, sys::IEquatable<TableName>
    {
        /// <summary>The possible contents of <see cref="TableName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>tables/{table}</c>.</summary>
            Table = 1,
        }

        private static gax::PathTemplate s_table = new gax::PathTemplate("tables/{table}");

        /// <summary>Creates a <see cref="TableName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TableName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TableName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TableName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="TableName"/> with the pattern <c>tables/{table}</c>.</summary>
        /// <param name="tableId">The <c>Table</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TableName"/> constructed from the provided ids.</returns>
        public static TableName FromTable(string tableId) =>
            new TableName(ResourceNameType.Table, tableId: gax::GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TableName"/> with pattern
        /// <c>tables/{table}</c>.
        /// </summary>
        /// <param name="tableId">The <c>Table</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TableName"/> with pattern <c>tables/{table}</c>.
        /// </returns>
        public static string Format(string tableId) => FormatTable(tableId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TableName"/> with pattern
        /// <c>tables/{table}</c>.
        /// </summary>
        /// <param name="tableId">The <c>Table</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TableName"/> with pattern <c>tables/{table}</c>.
        /// </returns>
        public static string FormatTable(string tableId) =>
            s_table.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)));

        /// <summary>Parses the given resource name string into a new <see cref="TableName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>tables/{table}</c></description></item></list>
        /// </remarks>
        /// <param name="tableName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TableName"/> if successful.</returns>
        public static TableName Parse(string tableName) => Parse(tableName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TableName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>tables/{table}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tableName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TableName"/> if successful.</returns>
        public static TableName Parse(string tableName, bool allowUnparsed) =>
            TryParse(tableName, allowUnparsed, out TableName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TableName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>tables/{table}</c></description></item></list>
        /// </remarks>
        /// <param name="tableName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TableName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tableName, out TableName result) => TryParse(tableName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TableName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>tables/{table}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tableName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TableName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tableName, bool allowUnparsed, out TableName result)
        {
            gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName));
            gax::TemplatedResourceName resourceName;
            if (s_table.TryParseName(tableName, out resourceName))
            {
                result = FromTable(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(tableName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TableName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string tableId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            TableId = tableId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TableName"/> class from the component parts of pattern
        /// <c>tables/{table}</c>
        /// </summary>
        /// <param name="tableId">The <c>Table</c> ID. Must not be <c>null</c> or empty.</param>
        public TableName(string tableId) : this(ResourceNameType.Table, tableId: gax::GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)))
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
        /// The <c>Table</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TableId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.Table: return s_table.Expand(TableId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TableName);

        /// <inheritdoc/>
        public bool Equals(TableName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TableName a, TableName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TableName a, TableName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Row</c> resource.</summary>
    public sealed partial class RowName : gax::IResourceName, sys::IEquatable<RowName>
    {
        /// <summary>The possible contents of <see cref="RowName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>tables/{table}/rows/{row}</c>.</summary>
            TableRow = 1,
        }

        private static gax::PathTemplate s_tableRow = new gax::PathTemplate("tables/{table}/rows/{row}");

        /// <summary>Creates a <see cref="RowName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RowName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RowName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RowName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="RowName"/> with the pattern <c>tables/{table}/rows/{row}</c>.</summary>
        /// <param name="tableId">The <c>Table</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="rowId">The <c>Row</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RowName"/> constructed from the provided ids.</returns>
        public static RowName FromTableRow(string tableId, string rowId) =>
            new RowName(ResourceNameType.TableRow, tableId: gax::GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)), rowId: gax::GaxPreconditions.CheckNotNullOrEmpty(rowId, nameof(rowId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RowName"/> with pattern
        /// <c>tables/{table}/rows/{row}</c>.
        /// </summary>
        /// <param name="tableId">The <c>Table</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="rowId">The <c>Row</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RowName"/> with pattern <c>tables/{table}/rows/{row}</c>.
        /// </returns>
        public static string Format(string tableId, string rowId) => FormatTableRow(tableId, rowId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RowName"/> with pattern
        /// <c>tables/{table}/rows/{row}</c>.
        /// </summary>
        /// <param name="tableId">The <c>Table</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="rowId">The <c>Row</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RowName"/> with pattern <c>tables/{table}/rows/{row}</c>.
        /// </returns>
        public static string FormatTableRow(string tableId, string rowId) =>
            s_tableRow.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)), gax::GaxPreconditions.CheckNotNullOrEmpty(rowId, nameof(rowId)));

        /// <summary>Parses the given resource name string into a new <see cref="RowName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>tables/{table}/rows/{row}</c></description></item></list>
        /// </remarks>
        /// <param name="rowName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RowName"/> if successful.</returns>
        public static RowName Parse(string rowName) => Parse(rowName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RowName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>tables/{table}/rows/{row}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="rowName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RowName"/> if successful.</returns>
        public static RowName Parse(string rowName, bool allowUnparsed) =>
            TryParse(rowName, allowUnparsed, out RowName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="RowName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>tables/{table}/rows/{row}</c></description></item></list>
        /// </remarks>
        /// <param name="rowName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RowName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string rowName, out RowName result) => TryParse(rowName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RowName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>tables/{table}/rows/{row}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="rowName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RowName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string rowName, bool allowUnparsed, out RowName result)
        {
            gax::GaxPreconditions.CheckNotNull(rowName, nameof(rowName));
            gax::TemplatedResourceName resourceName;
            if (s_tableRow.TryParseName(rowName, out resourceName))
            {
                result = FromTableRow(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(rowName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RowName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string rowId = null, string tableId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            RowId = rowId;
            TableId = tableId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RowName"/> class from the component parts of pattern
        /// <c>tables/{table}/rows/{row}</c>
        /// </summary>
        /// <param name="tableId">The <c>Table</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="rowId">The <c>Row</c> ID. Must not be <c>null</c> or empty.</param>
        public RowName(string tableId, string rowId) : this(ResourceNameType.TableRow, tableId: gax::GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)), rowId: gax::GaxPreconditions.CheckNotNullOrEmpty(rowId, nameof(rowId)))
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
        /// The <c>Row</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RowId { get; }

        /// <summary>
        /// The <c>Table</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TableId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.TableRow: return s_tableRow.Expand(TableId, RowId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RowName);

        /// <inheritdoc/>
        public bool Equals(RowName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RowName a, RowName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RowName a, RowName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Workspace</c> resource.</summary>
    public sealed partial class WorkspaceName : gax::IResourceName, sys::IEquatable<WorkspaceName>
    {
        /// <summary>The possible contents of <see cref="WorkspaceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>workspaces/{workspace}</c>.</summary>
            Workspace = 1,
        }

        private static gax::PathTemplate s_workspace = new gax::PathTemplate("workspaces/{workspace}");

        /// <summary>Creates a <see cref="WorkspaceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="WorkspaceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static WorkspaceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new WorkspaceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="WorkspaceName"/> with the pattern <c>workspaces/{workspace}</c>.</summary>
        /// <param name="workspaceId">The <c>Workspace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="WorkspaceName"/> constructed from the provided ids.</returns>
        public static WorkspaceName FromWorkspace(string workspaceId) =>
            new WorkspaceName(ResourceNameType.Workspace, workspaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(workspaceId, nameof(workspaceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkspaceName"/> with pattern
        /// <c>workspaces/{workspace}</c>.
        /// </summary>
        /// <param name="workspaceId">The <c>Workspace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WorkspaceName"/> with pattern <c>workspaces/{workspace}</c>.
        /// </returns>
        public static string Format(string workspaceId) => FormatWorkspace(workspaceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkspaceName"/> with pattern
        /// <c>workspaces/{workspace}</c>.
        /// </summary>
        /// <param name="workspaceId">The <c>Workspace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WorkspaceName"/> with pattern <c>workspaces/{workspace}</c>.
        /// </returns>
        public static string FormatWorkspace(string workspaceId) =>
            s_workspace.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(workspaceId, nameof(workspaceId)));

        /// <summary>Parses the given resource name string into a new <see cref="WorkspaceName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>workspaces/{workspace}</c></description></item></list>
        /// </remarks>
        /// <param name="workspaceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="WorkspaceName"/> if successful.</returns>
        public static WorkspaceName Parse(string workspaceName) => Parse(workspaceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="WorkspaceName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>workspaces/{workspace}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="workspaceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="WorkspaceName"/> if successful.</returns>
        public static WorkspaceName Parse(string workspaceName, bool allowUnparsed) =>
            TryParse(workspaceName, allowUnparsed, out WorkspaceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WorkspaceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>workspaces/{workspace}</c></description></item></list>
        /// </remarks>
        /// <param name="workspaceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WorkspaceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string workspaceName, out WorkspaceName result) => TryParse(workspaceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WorkspaceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>workspaces/{workspace}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="workspaceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WorkspaceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string workspaceName, bool allowUnparsed, out WorkspaceName result)
        {
            gax::GaxPreconditions.CheckNotNull(workspaceName, nameof(workspaceName));
            gax::TemplatedResourceName resourceName;
            if (s_workspace.TryParseName(workspaceName, out resourceName))
            {
                result = FromWorkspace(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(workspaceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private WorkspaceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string workspaceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="WorkspaceName"/> class from the component parts of pattern
        /// <c>workspaces/{workspace}</c>
        /// </summary>
        /// <param name="workspaceId">The <c>Workspace</c> ID. Must not be <c>null</c> or empty.</param>
        public WorkspaceName(string workspaceId) : this(ResourceNameType.Workspace, workspaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(workspaceId, nameof(workspaceId)))
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
        /// The <c>Workspace</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string WorkspaceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.Workspace: return s_workspace.Expand(WorkspaceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as WorkspaceName);

        /// <inheritdoc/>
        public bool Equals(WorkspaceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(WorkspaceName a, WorkspaceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(WorkspaceName a, WorkspaceName b) => !(a == b);
    }

    public partial class GetTableRequest
    {
        /// <summary>
        /// <see cref="gatv::TableName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gatv::TableName TableName
        {
            get => string.IsNullOrEmpty(Name) ? null : gatv::TableName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetWorkspaceRequest
    {
        /// <summary>
        /// <see cref="gatv::WorkspaceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gatv::WorkspaceName WorkspaceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gatv::WorkspaceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetRowRequest
    {
        /// <summary>
        /// <see cref="gatv::RowName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gatv::RowName RowName
        {
            get => string.IsNullOrEmpty(Name) ? null : gatv::RowName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteRowRequest
    {
        /// <summary>
        /// <see cref="gatv::RowName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gatv::RowName RowName
        {
            get => string.IsNullOrEmpty(Name) ? null : gatv::RowName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class BatchDeleteRowsRequest
    {
        /// <summary><see cref="TableName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public TableName ParentAsTableName
        {
            get => string.IsNullOrEmpty(Parent) ? null : TableName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary><see cref="RowName"/>-typed view over the <see cref="Names"/> resource name property.</summary>
        public gax::ResourceNameList<RowName> RowNames
        {
            get => new gax::ResourceNameList<RowName>(Names, s => string.IsNullOrEmpty(s) ? null : RowName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class Table
    {
        /// <summary>
        /// <see cref="gatv::TableName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gatv::TableName TableName
        {
            get => string.IsNullOrEmpty(Name) ? null : gatv::TableName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Row
    {
        /// <summary>
        /// <see cref="gatv::RowName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gatv::RowName RowName
        {
            get => string.IsNullOrEmpty(Name) ? null : gatv::RowName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Workspace
    {
        /// <summary>
        /// <see cref="gatv::WorkspaceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gatv::WorkspaceName WorkspaceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gatv::WorkspaceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
