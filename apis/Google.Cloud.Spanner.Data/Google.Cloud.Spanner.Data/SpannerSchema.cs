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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Globalization;
using Google.Cloud.Spanner.V1;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>Common ADO.NET schema collections for both Spanner SQL dialects.</summary>
    internal static class SpannerSchema
    {
        private static readonly string[] CollectionNames =
        {
            "MetaDataCollections", "DataSourceInformation", "DataTypes", "Restrictions", "ReservedWords"
        };

        internal static DataTable GetSchema(SpannerConnection connection, string collectionName, string[] restrictionValues)
        {
            if (collectionName == null) throw new ArgumentNullException(nameof(collectionName));
            if (collectionName.Length == 0)
                throw new ArgumentException("The schema collection name cannot be empty.", nameof(collectionName));
            if (restrictionValues != null && restrictionValues.Length > 0)
                throw new ArgumentException("Restrictions are not supported for the requested schema collection.",
                    nameof(restrictionValues));

            switch (collectionName.ToUpperInvariant())
            {
                case "METADATACOLLECTIONS": return GetCollections();
                case "RESTRICTIONS":
                    return Table("Restrictions",
                        ("CollectionName", typeof(string)), ("RestrictionName", typeof(string)),
                        ("RestrictionDefault", typeof(string)), ("RestrictionNumber", typeof(int)));
                case "DATASOURCEINFORMATION":
                    return GetDataSourceInformation(connection,
                        connection.State == ConnectionState.Open ? (bool?)IsPostgreSql(connection) : null);
                case "DATATYPES": return GetDataTypes(connection, IsPostgreSql(connection));
                case "RESERVEDWORDS": return GetReservedWords(IsPostgreSql(connection));
                default:
                    throw new ArgumentException($"The schema collection '{collectionName}' is not supported.",
                        nameof(collectionName));
            }
        }

        // information_schema.schemata.catalog_name is empty under GoogleSQL and
        // contains the database name under Spanner's PostgreSQL dialect.
        private static bool IsPostgreSql(SpannerConnection connection)
        {
            if (connection.State != ConnectionState.Open)
                throw new InvalidOperationException(
                    "The connection must be open to obtain dialect-specific schema metadata.");

            using (var command = connection.CreateSelectCommand(
                "SELECT catalog_name FROM information_schema.schemata LIMIT 1"))
            {
                var name = command.ExecuteScalar();
                if (name == null || name == DBNull.Value)
                    throw new InvalidOperationException("Unable to determine the Spanner SQL dialect.");
                return !string.IsNullOrEmpty(Convert.ToString(name, CultureInfo.InvariantCulture));
            }
        }

        private static DataTable GetCollections()
        {
            var table = Table("MetaDataCollections",
                ("CollectionName", typeof(string)),
                ("NumberOfRestrictions", typeof(int)),
                ("NumberOfIdentifierParts", typeof(int)));
            foreach (var name in CollectionNames) table.Rows.Add(name, 0, 0);
            return table;
        }

        internal static DataTable GetDataSourceInformation(SpannerConnection connection, bool? postgreSql)
        {
            var table = Table("DataSourceInformation",
                ("CompositeIdentifierSeparatorPattern", typeof(string)),
                ("DataSourceProductName", typeof(string)),
                ("DataSourceProductVersion", typeof(string)),
                ("DataSourceProductVersionNormalized", typeof(string)),
                ("GroupByBehavior", typeof(int)),
                ("IdentifierPattern", typeof(string)),
                ("IdentifierCase", typeof(int)),
                ("OrderByColumnsInSelect", typeof(bool)),
                ("ParameterMarkerFormat", typeof(string)),
                ("ParameterNameMaxLength", typeof(int)),
                ("ParameterNamePattern", typeof(string)),
                ("QuotedIdentifierPattern", typeof(string)),
                ("QuotedIdentifierCase", typeof(int)),
                ("StatementSeparatorPattern", typeof(string)),
                ("StringLiteralPattern", typeof(string)),
                ("SupportedJoinOperators", typeof(int)));
            var row = table.NewRow();
            row["DataSourceProductName"] = "Google Cloud Spanner";
            // The provider's ServerVersion is a placeholder ("0.0"), not a real
            // server version. ADO.NET permits DBNull for unknown schema values.
            row["CompositeIdentifierSeparatorPattern"] = @"\.";
            row["ParameterMarkerFormat"] = "@{0}";
            row["StatementSeparatorPattern"] = ";";
            if (postgreSql.HasValue)
            {
                // Spanner folds unquoted identifiers to lowercase for both
                // dialects; quoted identifiers preserve case.
                row["IdentifierPattern"] = @"^[\p{L}_][\p{L}\p{N}_]*$";
                row["ParameterNamePattern"] = @"^[\p{L}_][\p{L}\p{N}_]*$";
                row["IdentifierCase"] = (int)IdentifierCase.Insensitive;
                row["QuotedIdentifierCase"] = (int)IdentifierCase.Sensitive;
                // Spanner does not impose PostgreSQL's usual 63-byte identifier
                // limit on all object names; the limit varies by identifier kind.
                row["OrderByColumnsInSelect"] = true;
                row["GroupByBehavior"] = (int)GroupByBehavior.MustContainAll;
                row["SupportedJoinOperators"] = (int)(SupportedJoinOperators.Inner |
                    SupportedJoinOperators.LeftOuter | SupportedJoinOperators.RightOuter |
                    SupportedJoinOperators.FullOuter);
                row["QuotedIdentifierPattern"] = postgreSql.Value
                    ? "\"([^\"]|\"\")+\"" : @"\x60(?:[^\\\x60]|\\.)+\x60";
            }
            table.Rows.Add(row);
            return table;
        }

        // Start with the types defined by each Spanner dialect, then merge types
        // found in INFORMATION_SCHEMA.COLUMNS. The information schema is the
        // server-owned source for user-defined types and types added by newer
        // server releases. Unknown ADO.NET properties remain DBNull.
        internal static DataTable GetDataTypes(SpannerConnection connection, bool postgreSql)
        {
            var table = CreateDataTypesTable();
            var names = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            AddStandardDataTypes(table, names, postgreSql);
            using (var command = connection.CreateSelectCommand(
                "SELECT DISTINCT spanner_type FROM information_schema.columns ORDER BY spanner_type"))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (reader.IsDBNull(0))
                    {
                        continue;
                    }
                    string typeName = reader.GetString(0);
                    typeName = CanonicalTypeName(typeName);
                    if (names.Add(typeName)) AddObservedType(table, typeName, postgreSql);
                }
            }
            return table;
        }

        internal static DataTable CreateDataTypesTable() => Table("DataTypes",
                ("TypeName", typeof(string)), ("ProviderDbType", typeof(int)),
                ("ColumnSize", typeof(long)), ("CreateFormat", typeof(string)),
                ("CreateParameters", typeof(string)), ("DataType", typeof(string)),
                ("IsAutoincrementable", typeof(bool)), ("IsBestMatch", typeof(bool)),
                ("IsCaseSensitive", typeof(bool)), ("IsFixedLength", typeof(bool)),
                ("IsFixedPrecisionScale", typeof(bool)), ("IsLong", typeof(bool)),
                ("IsNullable", typeof(bool)), ("IsSearchable", typeof(bool)),
                ("IsSearchableWithLike", typeof(bool)), ("IsUnsigned", typeof(bool)),
                ("MaximumScale", typeof(short)), ("MinimumScale", typeof(short)),
                ("IsConcurrencyType", typeof(bool)), ("IsLiteralSupported", typeof(bool)),
                ("LiteralPrefix", typeof(string)), ("LiteralSuffix", typeof(string)));

        internal static void AddObservedType(DataTable table, string typeName, bool postgreSql)
        {
            var row = table.NewRow();
            row["TypeName"] = typeName;
            // Only the type name and CLR mapping are knowable from the Spanner
            // information schema. Leave the remaining ADO.NET descriptors DBNull
            // instead of guessing size, literal, or capability values.
            var clrType = GetClrType(typeName, postgreSql);
            if (clrType != null) row["DataType"] = clrType.FullName;
            table.Rows.Add(row);
        }

        internal static void AddStandardDataTypes(DataTable table, HashSet<string> names, bool postgreSql)
        {
            if (postgreSql)
            {
                AddType(table, names, "boolean", typeof(bool));
                AddType(table, names, "bigint", typeof(long), size: 19);
                AddType(table, names, "int8", typeof(long), size: 19,
                    bestMatch: false);
                AddType(table, names, "int", typeof(long), size: 19,
                    bestMatch: false);
                AddType(table, names, "real", typeof(float));
                AddType(table, names, "float4", typeof(float), bestMatch: false);
                AddType(table, names, "double precision", typeof(double));
                AddType(table, names, "float8", typeof(double), bestMatch: false);
                AddType(table, names, "numeric", typeof(PgNumeric));
                AddType(table, names, "decimal", typeof(PgNumeric), bestMatch: false);
                AddType(table, names, "character varying", typeof(string), format: "character varying({0})",
                    parameters: "length", stringType: true, longType: true);
                AddType(table, names, "varchar", typeof(string), format: "varchar({0})",
                    parameters: "length", stringType: true, longType: true, bestMatch: false);
                AddType(table, names, "text", typeof(string), stringType: true, longType: true, bestMatch: false);
                AddType(table, names, "bytea", typeof(byte[]), longType: true);
                AddType(table, names, "date", typeof(DateTime), bestMatch: false);
                AddType(table, names, "timestamp with time zone", typeof(DateTime));
                AddType(table, names, "jsonb", typeof(string), bestMatch: false);
                AddType(table, names, "uuid", typeof(Guid));
                AddType(table, names, "interval", typeof(Interval));
                AddType(table, names, "serial", typeof(long), bestMatch: false);
                AddType(table, names, "smallserial", typeof(long), bestMatch: false);
                AddType(table, names, "serial2", typeof(long), bestMatch: false);
                AddType(table, names, "serial4", typeof(long), bestMatch: false);
                AddType(table, names, "serial8", typeof(long), bestMatch: false);
                AddType(table, names, "bigserial", typeof(long), bestMatch: false);
                AddType(table, names, "spanner.commit_timestamp", typeof(DateTime), bestMatch: false);
                foreach (var (arrayName, elementName) in new[]
                {
                    ("boolean[]", "boolean"), ("bigint[]", "bigint"), ("real[]", "real"),
                    ("double precision[]", "double precision"), ("numeric[]", "numeric"),
                    ("character varying[]", "character varying"), ("text[]", "text"),
                    ("bytea[]", "bytea"), ("date[]", "date"),
                    ("timestamp with time zone[]", "timestamp with time zone"),
                    ("jsonb[]", "jsonb"), ("uuid[]", "uuid"), ("interval[]", "interval")
                })
                {
                    AddArrayType(table, names, arrayName, elementName, postgreSql: true);
                }
            }
            else
            {
                AddType(table, names, "BOOL", typeof(bool));
                AddType(table, names, "BOOLEAN", typeof(bool), bestMatch: false);
                AddType(table, names, "INT64", typeof(long), size: 19);
                AddType(table, names, "FLOAT32", typeof(float));
                AddType(table, names, "FLOAT64", typeof(double));
                AddType(table, names, "NUMERIC", typeof(SpannerNumeric),
                    fixedPrecisionScale: true, precision: 38, scale: 9);
                AddType(table, names, "STRING", typeof(string), format: "STRING({0})", parameters: "length",
                    stringType: true, longType: true);
                AddType(table, names, "BYTES", typeof(byte[]), format: "BYTES({0})", parameters: "length", longType: true);
                AddType(table, names, "DATE", typeof(DateTime), bestMatch: false);
                AddType(table, names, "TIMESTAMP", typeof(DateTime));
                AddType(table, names, "JSON", typeof(string), bestMatch: false);
                AddType(table, names, "UUID", typeof(Guid));
                AddType(table, names, "INTERVAL", typeof(Interval));
                foreach (var elementName in new[]
                {
                    "BOOL", "INT64", "FLOAT32", "FLOAT64", "NUMERIC", "STRING", "BYTES", "DATE",
                    "TIMESTAMP", "JSON", "UUID"
                })
                {
                    AddArrayType(table, names, $"ARRAY<{elementName}>", elementName, postgreSql: false);
                }
            }
        }

        private static void AddArrayType(DataTable table, HashSet<string> names, string typeName,
            string elementTypeName, bool postgreSql)
        {
            var elementType = GetClrType(elementTypeName, postgreSql);
            if (elementType == null) return;
            AddType(table, names, typeName, typeof(List<>).MakeGenericType(elementType),
                format: postgreSql ? "{0}[]" : "ARRAY<{0}>", parameters: "element type");
        }

        private static void AddType(DataTable table, HashSet<string> names, string typeName, System.Type clrType,
            bool fixedLength = false, long? size = null, string format = null, string parameters = null,
            bool stringType = false, bool longType = false, bool bestMatch = true,
            bool autoincrementable = false, bool fixedPrecisionScale = false, short? precision = null, short? scale = null)
        {
            if (!names.Add(typeName)) return;
            var row = table.NewRow();
            row["TypeName"] = typeName;
            row["DataType"] = clrType.FullName;
            row["CreateFormat"] = format ?? typeName;
            if (size.HasValue) row["ColumnSize"] = size.Value;
            if (parameters != null) row["CreateParameters"] = parameters;
            if (autoincrementable) row["IsAutoincrementable"] = true;
            row["IsBestMatch"] = bestMatch;
            row["IsCaseSensitive"] = stringType;
            if (fixedLength) row["IsFixedLength"] = true;
            row["IsFixedPrecisionScale"] = fixedPrecisionScale;
            if (longType) row["IsLong"] = true;
            row["IsSearchableWithLike"] = stringType ? (object)true : DBNull.Value;
            if (clrType == typeof(long) || clrType == typeof(float) || clrType == typeof(double) ||
                clrType == typeof(PgNumeric) || clrType == typeof(SpannerNumeric)) row["IsUnsigned"] = false;
            row["IsConcurrencyType"] = DBNull.Value;
            row["IsLiteralSupported"] = DBNull.Value;
            if (stringType)
            {
                row["LiteralPrefix"] = "'";
                row["LiteralSuffix"] = "'";
            }
            if (precision.HasValue)
            {
                row["ColumnSize"] = precision.Value;
                row["MaximumScale"] = scale.Value;
                row["MinimumScale"] = (short)0;
            }
            table.Rows.Add(row);
        }

        private static string CanonicalTypeName(string typeName)
        {
            // Column SPANNER_TYPE values can carry a declared string/bytes length.
            // The ADO.NET collection describes the type family, not one column's
            // chosen limit. Keep array element declarations intact.
            if (typeName.StartsWith("ARRAY<", StringComparison.OrdinalIgnoreCase))
            {
                return "ARRAY<" + CanonicalTypeName(typeName.Substring(6, typeName.Length - 7)) + ">";
            }
            if (typeName.EndsWith("[]", StringComparison.Ordinal))
            {
                return CanonicalTypeName(typeName.Substring(0, typeName.Length - 2)) + "[]";
            }
            int modifierStart = typeName.IndexOf('(');
            return modifierStart < 0 ? typeName : typeName.Substring(0, modifierStart).TrimEnd();
        }

        private static System.Type GetClrType(string typeName, bool postgreSql)
        {
            if (typeName.StartsWith("ARRAY<", StringComparison.OrdinalIgnoreCase) && typeName.EndsWith(">", StringComparison.Ordinal))
            {
                var elementType = GetClrType(typeName.Substring(6, typeName.Length - 7), postgreSql);
                return elementType == null ? null : typeof(System.Collections.Generic.List<>).MakeGenericType(elementType);
            }
            if (postgreSql && typeName.EndsWith("[]", StringComparison.Ordinal))
            {
                var elementType = GetClrType(typeName.Substring(0, typeName.Length - 2), true);
                return elementType == null ? null : typeof(System.Collections.Generic.List<>).MakeGenericType(elementType);
            }
            // Information schema type names can include modifiers such as
            // STRING(MAX) or character varying(100). The modifier affects the
            // database type declaration, not its provider CLR type.
            typeName = CanonicalTypeName(typeName);
            if (!postgreSql)
            {
                switch (typeName.ToUpperInvariant())
                {
                    case "BOOL": return typeof(bool);
                    case "INT64": return typeof(long);
                    case "FLOAT32": return typeof(float);
                    case "FLOAT64": return typeof(double);
                    case "NUMERIC": return typeof(SpannerNumeric);
                    case "STRING": return typeof(string);
                    case "BYTES": return typeof(byte[]);
                    case "DATE":
                    case "TIMESTAMP": return typeof(DateTime);
                    case "JSON": return typeof(string);
                    case "UUID": return typeof(Guid);
                    default: return null;
                }
            }
            switch (typeName.ToLowerInvariant())
            {
                case "bool":
                case "boolean": return typeof(bool);
                case "int8":
                case "bigint": return typeof(long);
                case "float4":
                case "real": return typeof(float);
                case "float8":
                case "double precision": return typeof(double);
                case "numeric": return typeof(PgNumeric);
                case "text":
                case "varchar":
                case "character varying": return typeof(string);
                case "bytea": return typeof(byte[]);
                case "date":
                case "timestamptz":
                case "timestamp with time zone": return typeof(DateTime);
                case "jsonb": return typeof(string);
                case "uuid": return typeof(Guid);
                case "interval": return typeof(Interval);
                default: return null;
            }
        }

        internal static DataTable GetReservedWords(bool postgreSql)
        {
            var table = Table("ReservedWords", ("ReservedWord", typeof(string)));
            // Spanner exposes dialect metadata through INFORMATION_SCHEMA, but
            // currently has no SQL catalog for parser keywords. These lists follow
            // the published language references; type/dialect selection is queried
            // from the connected database.
            foreach (string word in (postgreSql ? PostgreSqlReservedWords : GoogleSqlReservedWords)
                .Split(new[] { ' ', '\r', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries))
            {
                table.Rows.Add(word);
            }
            return table;
        }

        private const string GoogleSqlReservedWords =
            "ALL AND ANY ARRAY AS ASC ASSERT_ROWS_MODIFIED AT BETWEEN BY CASE CAST COLLATE CONTAINS " +
            "CREATE CROSS CUBE CURRENT DEFAULT DEFINE DESC DISTINCT ELSE END ENUM ESCAPE EXCEPT EXCLUDE " +
            "EXISTS EXTRACT FALSE FETCH FOLLOWING FOR FROM FULL GRAPH_TABLE GROUP GROUPING GROUPS HASH " +
            "HAVING IF IGNORE IN INNER INTERSECT INTERVAL INTO IS JOIN LATERAL LEFT LIKE LIMIT LOOKUP " +
            "MERGE NATURAL NEW NO NOT NULL NULLS OF ON OR ORDER OUTER OVER PARTITION PRECEDING PROTO " +
            "RANGE RECURSIVE RESPECT RIGHT ROLLUP ROWS SELECT SET SOME STRUCT TABLESAMPLE THEN " +
            "TO TREAT TRUE UNBOUNDED UNION UNNEST USING WHEN WHERE WINDOW WITH WITHIN";

        // PostgreSQL 15 RESERVED_KEYWORD tokens. Spanner does not expose a keyword
        // catalog for its PostgreSQL parser; this is the documented language baseline.
        private const string PostgreSqlReservedWords =
            "ALL ANALYSE ANALYZE AND ANY ARRAY AS ASC ASYMMETRIC BOTH CASE CAST CHECK COLLATE COLUMN " +
            "CONSTRAINT CREATE CURRENT_CATALOG CURRENT_DATE CURRENT_ROLE CURRENT_TIME CURRENT_TIMESTAMP " +
            "CURRENT_USER DEFAULT DEFERRABLE DESC DISTINCT DO ELSE END EXCEPT FALSE FETCH FOR FOREIGN " +
            "FROM GRANT GROUP HAVING IN INITIALLY INTERSECT INTO LATERAL LEADING LIMIT LOCALTIME " +
            "LOCALTIMESTAMP NOT NULL OFFSET ON ONLY OR ORDER PLACING PRIMARY REFERENCES RETURNING " +
            "SESSION_USER SOME SYMMETRIC TABLE THEN TO TRAILING TRUE UNION UNIQUE USER USING VARIADIC " +
            "WHEN WHERE WINDOW WITH";

        private static DataTable Table(string name, params (string column, System.Type type)[] columns)
        {
            var table = new DataTable(name);
            foreach (var (column, type) in columns) table.Columns.Add(column, type);
            return table;
        }
    }
}
