// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

using Google.Cloud.Spanner.Data.CommonTesting;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests;

[CollectionDefinition(nameof(AllTypesTableFixturePostgreSql))]
public class AllTypesTableFixturePostgreSql : SpannerTableFixturePostgreSql, ICollectionFixture<AllTypesTableFixturePostgreSql>
{
    public AllTypesTableFixturePostgreSql() : base("TypesTable")
    {
    }

    /// <summary>
    /// Creates INSERT command for the table created after executing the <see cref="CreateTable"/> method execution.
    /// </summary>
    /// <returns>The DML command to insert data into a table.</returns>
    public string CreateInsertCommand() =>
        $@"INSERT INTO {TableName} (
            K,
            ""Int64Value"",
            ""BoolValue"",
            ""Float64Value"",
            ""StringValue"",
            ""PgNumericValue"",
            ""BytesValue"",
            ""TimestampValue"",
            ""DateValue"",           
            ""BoolArrayValue"",
            ""Int64ArrayValue"",
            ""Float64ArrayValue"",
            ""PgNumericArrayValue"",
            ""StringArrayValue"",                 
            ""BytesArrayValue"",
            ""Base64ArrayValue"",
            ""TimestampArrayValue"",
            ""DateArrayValue""           
            ) VALUES(
            $1, 
            $2, 
            $3, 
            $4, 
            $5, 
            $6, 
            $7, 
            $8, 
            $9, 
            $10,
            $11,
            $12,
            $13,
            $14,
            $15, 
            $16,      
            $17,
            $18 
            )";

    protected override void CreateTable() =>
        // PostgreSQL column names are folded to lower case if not double quoted while table creation.
        ExecuteDdl($@"CREATE TABLE {TableName}(
            K                       VARCHAR(4096) NOT NULL PRIMARY KEY,
            ""Int64Value""          BIGINT,
            ""BoolValue""           BOOLEAN,
            ""Float64Value""        FLOAT,
            ""StringValue""         TEXT,
            ""PgNumericValue""      NUMERIC,
            ""BytesValue""          BYTEA,
            ""TimestampValue""      TIMESTAMPTZ,
            ""DateValue""           DATE,
            ""BoolArrayValue""      BOOLEAN[],
            ""Int64ArrayValue""     BIGINT[],
            ""Float64ArrayValue""   FLOAT[],
            ""PgNumericArrayValue"" NUMERIC[],
            ""StringArrayValue""    TEXT[],
            ""BytesArrayValue""     BYTEA[],
            ""Base64ArrayValue""    BYTEA[],
            ""TimestampArrayValue"" TIMESTAMPTZ[],
            ""DateArrayValue""      DATE[]
            );");
}
