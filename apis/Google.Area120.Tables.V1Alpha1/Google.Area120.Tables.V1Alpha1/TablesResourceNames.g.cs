// Copyright 2021 Google LLC
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

using gax = Google.Api.Gax;
using gatv = Google.Area120.Tables.V1Alpha1;
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

        /// <inheritdoc/>
        public static bool operator ==(TableName a, TableName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public static bool operator ==(RowName a, RowName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(RowName a, RowName b) => !(a == b);
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
}
