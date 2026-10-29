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
                case "DATATYPES": return GetDataTypes(IsPostgreSql(connection));
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

        private static DataTable GetDataSourceInformation(SpannerConnection connection, bool? postgreSql)
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
            row["ParameterNamePattern"] = @"^[A-Za-z_][A-Za-z0-9_]*$";
            row["StatementSeparatorPattern"] = ";";
            if (postgreSql.HasValue)
            {
                row["IdentifierPattern"] = @"^[A-Za-z_][A-Za-z0-9_]*$";
                row["OrderByColumnsInSelect"] = false;
                row["GroupByBehavior"] = (int)GroupByBehavior.MustContainAll;
                row["SupportedJoinOperators"] = (int)(SupportedJoinOperators.Inner |
                    SupportedJoinOperators.LeftOuter | SupportedJoinOperators.RightOuter |
                    SupportedJoinOperators.FullOuter);
                row["QuotedIdentifierPattern"] = postgreSql.Value
                    ? "\"([^\"]|\"\")*\"" : @"\x60([^\x60]|\x60\x60)*\x60";
            }
            table.Rows.Add(row);
            return table;
        }

        internal static DataTable GetDataTypes(bool postgreSql)
        {
            var table = Table("DataTypes",
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
            if (postgreSql)
            {
                AddType(table, "boolean", typeof(bool), fixedLength: true);
                AddType(table, "bigint", typeof(long), fixedLength: true, size: 19);
                AddType(table, "real", typeof(float), fixedLength: true);
                AddType(table, "double precision", typeof(double), fixedLength: true);
                AddType(table, "numeric", typeof(PgNumeric));
                AddType(table, "character varying", typeof(string), format: "character varying({0})",
                    parameters: "length", size: 2621440, stringType: true);
                AddType(table, "text", typeof(string), stringType: true, bestMatch: false);
                AddType(table, "bytea", typeof(byte[]));
                AddType(table, "date", typeof(DateTime), fixedLength: true, size: 10, bestMatch: false);
                AddType(table, "timestamp with time zone", typeof(DateTime), fixedLength: true);
                AddType(table, "jsonb", typeof(string), bestMatch: false);
                AddType(table, "uuid", typeof(Guid), fixedLength: true, size: 36);
                AddType(table, "interval", typeof(Interval));
                AddType(table, "bigint[]", typeof(List<long>));
            }
            else
            {
                AddType(table, "BOOL", typeof(bool), fixedLength: true);
                AddType(table, "INT64", typeof(long), fixedLength: true, size: 19);
                AddType(table, "FLOAT32", typeof(float), fixedLength: true);
                AddType(table, "FLOAT64", typeof(double), fixedLength: true);
                AddType(table, "NUMERIC", typeof(SpannerNumeric), fixedLength: true, size: 38, scale: 9);
                AddType(table, "STRING", typeof(string), format: "STRING({0})", parameters: "length",
                    stringType: true);
                AddType(table, "BYTES", typeof(byte[]), format: "BYTES({0})", parameters: "length");
                AddType(table, "DATE", typeof(DateTime), fixedLength: true, size: 10, bestMatch: false);
                AddType(table, "TIMESTAMP", typeof(DateTime), fixedLength: true);
                AddType(table, "JSON", typeof(string), bestMatch: false);
                AddType(table, "UUID", typeof(Guid), fixedLength: true, size: 36);
                AddType(table, "ARRAY<INT64>", typeof(List<long>));
            }
            return table;
        }

        private static void AddType(DataTable table, string type, Type clr, bool fixedLength = false,
            long? size = null, string format = null, string parameters = null,
            bool stringType = false, bool bestMatch = true, short? scale = null)
        {
            var row = table.NewRow();
            row["TypeName"] = type;
            // SpannerDbType is an object, not a numeric provider-specific enum.
            // In particular, (int)DbType is NOT a ProviderDbType value.
            row["DataType"] = clr.FullName;
            row["CreateFormat"] = format ?? type;
            if (parameters != null) row["CreateParameters"] = parameters;
            if (size.HasValue) row["ColumnSize"] = size.Value;
            row["IsBestMatch"] = bestMatch;
            row["IsCaseSensitive"] = stringType;
            row["IsFixedLength"] = fixedLength;
            row["IsNullable"] = true;
            row["IsConcurrencyType"] = false;
            row["IsLong"] = stringType || clr == typeof(byte[]);
            // Integer keys can be generated using sequences/identity syntax.
            // Do not claim universal non-autoincrementability for bigint/INT64.
            if (clr != typeof(long)) row["IsAutoincrementable"] = false;
            row["IsFixedPrecisionScale"] = scale.HasValue;
            row["IsUnsigned"] = false;
            row["IsSearchable"] = true;
            if (!stringType) row["IsSearchableWithLike"] = false;
            if (stringType)
            {
                row["IsSearchableWithLike"] = true;
                row["IsLiteralSupported"] = true;
                row["LiteralPrefix"] = "'";
                row["LiteralSuffix"] = "'";
            }
            if (scale.HasValue)
            {
                row["MinimumScale"] = scale.Value;
                row["MaximumScale"] = scale.Value;
                row["IsFixedPrecisionScale"] = true;
            }
            table.Rows.Add(row);
        }

        internal static DataTable GetReservedWords(bool postgreSql)
        {
            var table = Table("ReservedWords", ("ReservedWord", typeof(string)));
            foreach (var word in (postgreSql ? PostgreSqlReservedWords : GoogleSqlReservedWords)
                .Split(new[] { ' ', '\r', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries))
                table.Rows.Add(word);
            return table;
        }

        // https://cloud.google.com/spanner/docs/reference/standard-sql/lexical
        private const string GoogleSqlReservedWords =
            "ALL AND ANY ARRAY AS ASC ASSERT_ROWS_MODIFIED AT BETWEEN BY CASE CAST COLLATE" +
            "CONTAINS CREATE CROSS CUBE CURRENT DEFAULT DEFINE DESC DISTINCT ELSE END ENUM" +
            "ESCAPE EXCEPT EXCLUDE EXISTS EXTRACT FALSE FETCH FOLLOWING FOR FROM FULL" +
            "GRAPH_TABLE GROUP GROUPING GROUPS HASH HAVING IF IGNORE IN INNER INTERSECT" +
            "INTERVAL INTO IS JOIN LATERAL LEFT LIKE LIMIT LOOKUP MERGE NATURAL NEW NO NOT" +
            "NULL NULLS OF ON OR ORDER OUTER OVER PARTITION PRECEDING PROTO QUALIFY RANGE" +
            "RECURSIVE RESPECT RIGHT ROLLUP ROWS SELECT SET SOME STRUCT TABLESAMPLE THEN" +
            "TO TREAT TRUE UNBOUNDED UNION UNNEST USING WHEN WHERE WINDOW WITH WITHIN";

        // PostgreSQL 15 parser's RESERVED_KEYWORD entries, not unreserved keywords.
        // https://github.com/postgres/postgres/blob/REL_15_STABLE/src/include/parser/kwlist.h
        private const string PostgreSqlReservedWords =
            "ALL ANALYSE ANALYZE AND ANY ARRAY AS ASC ASYMMETRIC BOTH CASE CAST CHECK" +
            "COLLATE COLUMN CONSTRAINT CREATE CURRENT_CATALOG CURRENT_DATE CURRENT_ROLE" +
            "CURRENT_TIME CURRENT_TIMESTAMP CURRENT_USER DEFAULT DEFERRABLE DESC DISTINCT" +
            "DO ELSE END EXCEPT FALSE FETCH FOR FOREIGN FROM GRANT GROUP HAVING IN" +
            "INITIALLY INTERSECT INTO LATERAL LEADING LIMIT LOCALTIME LOCALTIMESTAMP NOT" +
            "NULL OFFSET ON ONLY OR ORDER PLACING PRIMARY REFERENCES RETURNING SELECT" +
            "SESSION_USER SOME SYMMETRIC TABLE THEN TO TRAILING TRUE UNION UNIQUE USER" +
            "USING VARIADIC WHEN WHERE WINDOW WITH";

        private static DataTable Table(string name, params (string column, Type type)[] columns)
        {
            var table = new DataTable(name);
            foreach (var (column, type) in columns) table.Columns.Add(column, type);
            return table;
        }
    }
}
