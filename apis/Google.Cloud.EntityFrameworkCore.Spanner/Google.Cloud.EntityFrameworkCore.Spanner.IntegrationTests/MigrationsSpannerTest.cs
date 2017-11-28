// Copyright 2017 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Data.Common;
using Google.Cloud.Spanner.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Xunit;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests
{
    public class MigrationsSpannerTest : MigrationsTestBase<MigrationsSpannerFixture>
    {
        public MigrationsSpannerTest(MigrationsSpannerFixture fixture)
            : base(fixture)
        {
        }

        private const string FileLineEnding = @"
";

        public override void Can_generate_idempotent_up_scripts()
        {
            base.Can_generate_idempotent_up_scripts();

            Assert.Equal(
                @"CREATE TABLE IF NOT EXISTS ""__EFMigrationsHistory"" (
    ""MigrationId"" varchar(150) NOT NULL,
    ""ProductVersion"" varchar(32) NOT NULL,
    CONSTRAINT ""PK___EFMigrationsHistory"" PRIMARY KEY (""MigrationId"")
);


DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM ""__EFMigrationsHistory"" WHERE ""MigrationId"" = '00000000000001_Migration1') THEN
    CREATE TABLE ""Table1"" (
        ""Id"" int4 NOT NULL,
        CONSTRAINT ""PK_Table1"" PRIMARY KEY (""Id"")
    );
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM ""__EFMigrationsHistory"" WHERE ""MigrationId"" = '00000000000001_Migration1') THEN
    INSERT INTO ""__EFMigrationsHistory"" (""MigrationId"", ""ProductVersion"")
    VALUES ('00000000000001_Migration1', '7.0.0-test');
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM ""__EFMigrationsHistory"" WHERE ""MigrationId"" = '00000000000002_Migration2') THEN
    ALTER TABLE ""Table1"" RENAME TO ""Table2"";
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM ""__EFMigrationsHistory"" WHERE ""MigrationId"" = '00000000000002_Migration2') THEN
    INSERT INTO ""__EFMigrationsHistory"" (""MigrationId"", ""ProductVersion"")
    VALUES ('00000000000002_Migration2', '7.0.0-test');
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM ""__EFMigrationsHistory"" WHERE ""MigrationId"" = '00000000000003_Migration3') THEN
    INSERT INTO ""__EFMigrationsHistory"" (""MigrationId"", ""ProductVersion"")
    VALUES ('00000000000003_Migration3', '7.0.0-test');
    END IF;
END $$;
", Sql.Replace(Environment.NewLine, FileLineEnding));
        }

        public override void Can_generate_idempotent_down_scripts()
        {
            base.Can_generate_idempotent_down_scripts();

            Assert.Equal(@"
DO $$
BEGIN
    IF EXISTS(SELECT 1 FROM ""__EFMigrationsHistory"" WHERE ""MigrationId"" = '00000000000002_Migration2') THEN
    ALTER TABLE ""Table2"" RENAME TO ""Table1"";
    END IF;
END $$;

DO $$
BEGIN
    IF EXISTS(SELECT 1 FROM ""__EFMigrationsHistory"" WHERE ""MigrationId"" = '00000000000002_Migration2') THEN
    DELETE FROM ""__EFMigrationsHistory""
    WHERE ""MigrationId"" = '00000000000002_Migration2';
    END IF;
END $$;

DO $$
BEGIN
    IF EXISTS(SELECT 1 FROM ""__EFMigrationsHistory"" WHERE ""MigrationId"" = '00000000000001_Migration1') THEN
    DROP TABLE ""Table1"";
    END IF;
END $$;

DO $$
BEGIN
    IF EXISTS(SELECT 1 FROM ""__EFMigrationsHistory"" WHERE ""MigrationId"" = '00000000000001_Migration1') THEN
    DELETE FROM ""__EFMigrationsHistory""
    WHERE ""MigrationId"" = '00000000000001_Migration1';
    END IF;
END $$;
", Sql.Replace(Environment.NewLine, FileLineEnding));
        }

        protected override void AssertFirstMigration(DbConnection connection)
        {
            var sql = GetDatabaseSchemaAsync(connection);
            Assert.Equal(
                @"
CreatedTable
    Id int4 NOT NULL
    ColumnWithDefaultToDrop int4 NULL DEFAULT 0
    ColumnWithDefaultToAlter int4 NULL DEFAULT 1
",
                sql.Replace(Environment.NewLine, FileLineEnding));
        }

        protected override void BuildSecondMigration(MigrationBuilder migrationBuilder)
        {
            base.BuildSecondMigration(migrationBuilder);

            for (var i = migrationBuilder.Operations.Count - 1; i >= 0; i--)
            {
                var operation = migrationBuilder.Operations[i];
                if (operation is AlterColumnOperation
                    || operation is DropColumnOperation)
                {
                    migrationBuilder.Operations.RemoveAt(i);
                }
            }
        }

        protected override void AssertSecondMigration(DbConnection connection)
        {
            var sql = GetDatabaseSchemaAsync(connection);
            Assert.Equal(
                @"
CreatedTable
    Id int4 NOT NULL
    ColumnWithDefaultToDrop int4 NULL DEFAULT 0
    ColumnWithDefaultToAlter int4 NULL DEFAULT 1
",
                sql.Replace(Environment.NewLine, FileLineEnding));
        }

        private string GetDatabaseSchemaAsync(DbConnection connection)
        {
            var builder = new IndentedStringBuilder();
            var command = connection.CreateCommand();
            command.CommandText = @"
SELECT table_name,
	column_name,
	udt_name,
	is_nullable = 'YES',
	column_default
FROM information_schema.columns
WHERE table_catalog = @db
	AND table_schema = 'public'
ORDER BY table_name, ordinal_position
";

            var dbName = connection.Database;
            var npgConnection = (SpannerConnection) connection;
            command.Parameters.Add(new SpannerParameter {ParameterName = "db", Value = dbName});

            using (var reader = command.ExecuteReader())
            {
                var first = true;
                string lastTable = null;
                while (reader.Read())
                {
                    var currentTable = reader.GetString(0);
                    if (currentTable != lastTable)
                    {
                        if (first)
                        {
                            first = false;
                        }
                        else
                        {
                            builder.DecrementIndent();
                        }

                        builder
                            .AppendLine()
                            .AppendLine(currentTable)
                            .IncrementIndent();

                        lastTable = currentTable;
                    }

                    builder
                        .Append(reader[1]) // Name
                        .Append(" ")
                        .Append(reader[2]) // Type
                        .Append(" ")
                        .Append(reader.GetBoolean(3) ? "NULL" : "NOT NULL");

                    if (!reader.IsDBNull(4))
                    {
                        builder
                            .Append(" DEFAULT ")
                            .Append(reader[4]);
                    }

                    builder.AppendLine();
                }
            }

            return builder.ToString();
        }
    }
}