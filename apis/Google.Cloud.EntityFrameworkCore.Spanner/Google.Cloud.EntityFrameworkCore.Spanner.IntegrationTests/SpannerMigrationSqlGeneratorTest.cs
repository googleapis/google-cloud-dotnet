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
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Xunit;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests
{
    public class SpannerMigrationSqlGeneratorTest : MigrationSqlGeneratorTestBase
    {
        public SpannerMigrationSqlGeneratorTest()
            : base(SpannerTestHelpers.Instance)
        {
        }

        [Fact]
        public override void AddColumnOperation_with_defaultValue()
        {
            base.AddColumnOperation_with_defaultValue();

            Assert.Equal(
                "ALTER TABLE \"dbo\".\"People\" ADD \"Name\" varchar(30) NOT NULL DEFAULT 'John Doe';" + EOL,
                Sql);
        }

        [Fact]
        public override void AddColumnOperation_with_defaultValueSql()
        {
            base.AddColumnOperation_with_defaultValueSql();

            Assert.Equal(
                "ALTER TABLE \"People\" ADD \"Birthday\" date NULL DEFAULT (CURRENT_TIMESTAMP);" + EOL,
                Sql);
        }

        [Fact]
        public override void AddColumnOperation_without_column_type()
        {
            base.AddColumnOperation_without_column_type();

            Assert.Equal(
                "ALTER TABLE \"People\" ADD \"Alias\" text NOT NULL;" + EOL,
                Sql);
        }

        [Fact]
        public override void AddColumnOperation_with_maxLength()
        {
            base.AddColumnOperation_with_maxLength();

            Assert.Equal(
                @"ALTER TABLE ""Person"" ADD ""Name"" varchar(30) NULL;" + EOL,
                Sql);
        }

        [Fact]
        public override void AddForeignKeyOperation_with_name()
        {
            base.AddForeignKeyOperation_with_name();

            Assert.Equal(
                "ALTER TABLE \"dbo\".\"People\" ADD CONSTRAINT \"FK_People_Companies\" FOREIGN KEY (\"EmployerId1\", \"EmployerId2\") REFERENCES \"hr\".\"Companies\" (\"Id1\", \"Id2\") ON DELETE CASCADE;" +
                EOL,
                Sql);
        }

        [Fact]
        public override void AddForeignKeyOperation_without_name()
        {
            base.AddForeignKeyOperation_without_name();

            Assert.Equal(
                "ALTER TABLE \"People\" ADD FOREIGN KEY (\"SpouseId\") REFERENCES \"People\" (\"Id\");" + EOL,
                Sql);
        }

        [Fact]
        public override void AddPrimaryKeyOperation_with_name()
        {
            base.AddPrimaryKeyOperation_with_name();

            Assert.Equal(
                "ALTER TABLE \"dbo\".\"People\" ADD CONSTRAINT \"PK_People\" PRIMARY KEY (\"Id1\", \"Id2\");" + EOL,
                Sql);
        }

        [Fact]
        public override void AddPrimaryKeyOperation_without_name()
        {
            base.AddPrimaryKeyOperation_without_name();

            Assert.Equal(
                "ALTER TABLE \"People\" ADD PRIMARY KEY (\"Id\");" + EOL,
                Sql);
        }

        [Fact]
        public override void AddUniqueConstraintOperation_with_name()
        {
            base.AddUniqueConstraintOperation_with_name();

            Assert.Equal(
                "ALTER TABLE \"dbo\".\"People\" ADD CONSTRAINT \"AK_People_DriverLicense\" UNIQUE (\"DriverLicense_State\", \"DriverLicense_Number\");" +
                EOL,
                Sql);
        }

        [Fact]
        public override void AddUniqueConstraintOperation_without_name()
        {
            base.AddUniqueConstraintOperation_without_name();

            Assert.Equal(
                "ALTER TABLE \"People\" ADD UNIQUE (\"SSN\");" + EOL,
                Sql);
        }

        [Fact]
        public override void AlterSequenceOperation_with_minValue_and_maxValue()
        {
            base.AlterSequenceOperation_with_minValue_and_maxValue();

            Assert.Equal(
                "ALTER SEQUENCE \"dbo\".\"EntityFrameworkHiLoSequence\" INCREMENT BY 1 MINVALUE 2 MAXVALUE 816 CYCLE;" +
                EOL,
                Sql);
        }

        [Fact]
        public override void AlterSequenceOperation_without_minValue_and_maxValue()
        {
            base.AlterSequenceOperation_without_minValue_and_maxValue();

            Assert.Equal(
                "ALTER SEQUENCE \"EntityFrameworkHiLoSequence\" INCREMENT BY 1 NO MINVALUE NO MAXVALUE NO CYCLE;" + EOL,
                Sql);
        }

        [Fact]
        public override void CreateIndexOperation_unique()
        {
            base.CreateIndexOperation_unique();

            Assert.Equal(
                "CREATE UNIQUE INDEX \"IX_People_Name\" ON \"dbo\".\"People\" (\"FirstName\", \"LastName\");" + EOL,
                Sql);
        }

        [Fact]
        public override void CreateIndexOperation_nonunique()
        {
            base.CreateIndexOperation_nonunique();

            Assert.Equal(
                "CREATE INDEX \"IX_People_Name\" ON \"People\" (\"Name\");" + EOL,
                Sql);
        }

        [Fact]
        public override void CreateSequenceOperation_with_minValue_and_maxValue()
        {
            base.CreateSequenceOperation_with_minValue_and_maxValue();

            Assert.Equal(
                "CREATE SEQUENCE \"dbo\".\"EntityFrameworkHiLoSequence\" START WITH 3 INCREMENT BY 1 MINVALUE 2 MAXVALUE 816 CYCLE;" +
                EOL,
                Sql);
        }

        [Fact]
        public override void CreateSequenceOperation_without_minValue_and_maxValue()
        {
            base.CreateSequenceOperation_without_minValue_and_maxValue();

            Assert.Equal(
                "CREATE SEQUENCE \"EntityFrameworkHiLoSequence\" START WITH 3 INCREMENT BY 1 NO MINVALUE NO MAXVALUE NO CYCLE;" +
                EOL,
                Sql);
        }

        [Fact]
        public override void CreateTableOperation()
        {
            base.CreateTableOperation();

            Assert.Equal(
                "CREATE TABLE \"dbo\".\"People\" (" + EOL +
                "    \"Id\" int4 NOT NULL," + EOL +
                "    \"EmployerId\" int4 NULL," + EOL +
                "    \"SSN\" char(11) NULL," + EOL +
                "    PRIMARY KEY (\"Id\")," + EOL +
                "    UNIQUE (\"SSN\")," + EOL +
                "    FOREIGN KEY (\"EmployerId\") REFERENCES \"Companies\" (\"Id\")" + EOL +
                ");" + EOL,
                Sql);
        }

        [Fact]
        public override void DropColumnOperation()
        {
            base.DropColumnOperation();

            Assert.Equal(
                "ALTER TABLE \"dbo\".\"People\" DROP COLUMN \"LuckyNumber\";" + EOL,
                Sql);
        }

        [Fact]
        public override void DropForeignKeyOperation()
        {
            base.DropForeignKeyOperation();

            Assert.Equal(
                "ALTER TABLE \"dbo\".\"People\" DROP CONSTRAINT \"FK_People_Companies\";" + EOL,
                Sql);
        }

        [Fact]
        public override void DropPrimaryKeyOperation()
        {
            base.DropPrimaryKeyOperation();

            Assert.Equal(
                "ALTER TABLE \"dbo\".\"People\" DROP CONSTRAINT \"PK_People\";" + EOL,
                Sql);
        }

        [Fact]
        public override void DropSequenceOperation()
        {
            base.DropSequenceOperation();

            Assert.Equal(
                "DROP SEQUENCE \"dbo\".\"EntityFrameworkHiLoSequence\";" + EOL,
                Sql);
        }

        [Fact]
        public override void DropTableOperation()
        {
            base.DropTableOperation();

            Assert.Equal(
                "DROP TABLE \"dbo\".\"People\";" + EOL,
                Sql);
        }

        [Fact]
        public override void DropUniqueConstraintOperation()
        {
            base.DropUniqueConstraintOperation();

            Assert.Equal(
                "ALTER TABLE \"dbo\".\"People\" DROP CONSTRAINT \"AK_People_SSN\";" + EOL,
                Sql);
        }

        [Fact]
        public override void AlterColumnOperation()
        {
            base.AlterColumnOperation();

            Assert.Equal(
                @"ALTER TABLE ""dbo"".""People"" ALTER COLUMN ""LuckyNumber"" TYPE int;" + EOL +
                @"ALTER TABLE ""dbo"".""People"" ALTER COLUMN ""LuckyNumber"" SET NOT NULL;" + EOL +
                @"ALTER TABLE ""dbo"".""People"" ALTER COLUMN ""LuckyNumber"" SET DEFAULT 7;" + EOL,
                Sql);
        }

        [Fact]
        public override void AlterColumnOperation_without_column_type()
        {
            base.AlterColumnOperation_without_column_type();

            Assert.Equal(
                @"ALTER TABLE ""People"" ALTER COLUMN ""LuckyNumber"" TYPE int4;" + EOL +
                @"ALTER TABLE ""People"" ALTER COLUMN ""LuckyNumber"" SET NOT NULL;" + EOL +
                @"ALTER TABLE ""People"" ALTER COLUMN ""LuckyNumber"" DROP DEFAULT;" + EOL,
                Sql);
        }

        [Fact]
        public virtual void AddColumnOperation_serial()
        {
            //TODO(benwu): SerialColumn?
//            Generate(new AddColumnOperation
//            {
//                Table = "People",
//                Name = "foo",
//                ClrType = typeof(int),
//                ColumnType = "int",
//                IsNullable = false,
//                [SpannerAnnotationNames.ValueGenerationStrategy] = SpannerValueGenerationStrategy.SerialColumn
//            });

//            Assert.Equal(
//                "ALTER TABLE \"People\" ADD \"foo\" serial NOT NULL;" + EOL,
//                Sql);
        }

#pragma warning disable 618
        [Fact]
        public virtual void AddColumnOperation_serial_old_annotation_throws()
        {
            //TODO(benwu): ValueGeneratedOnAdd?

//            Assert.Throws<NotSupportedException>(() =>
//                Generate(new AddColumnOperation
//                {
//                    Table = "People",
//                    Name = "foo",
//                    ClrType = typeof(int),
//                    ColumnType = "int",
//                    IsNullable = false,
//                    [SpannerAnnotationNames.ValueGeneratedOnAdd] = true
//                }));
        }
#pragma warning restore 618

        // EFCore will add a default in some cases, e.g. adding a non-nullable column
        // to an existing table. This shouldn't affect serial column creation.
        // See #68
        [Fact]
        public void AddColumnOperation_serial_with_default()
        {
            //TODO(benwu): SerialColumn?

//            Generate(
//                new AddColumnOperation
//                {
//                    Table = "People",
//                    Name = "foo",
//                    ClrType = typeof(int),
//                    ColumnType = "int",
//                    DefaultValue = 0,
//                    [SpannerAnnotationNames.ValueGenerationStrategy] = SpannerValueGenerationStrategy.SerialColumn
//                });
//
//            Assert.Equal(
//                @"ALTER TABLE ""People"" ADD ""foo"" serial NOT NULL DEFAULT 0;" + EOL,
//                Sql);
        }

        [Fact]
        public void AddColumnOperation_with_comment()
        {
            //TODO(benwu): Comment?

//            Generate(new AddColumnOperation
//            {
//                Schema = "dbo",
//                Table = "People",
//                Name = "foo",
//                ClrType = typeof(int),
//                ColumnType = "int",
//                IsNullable = false,
//                [SpannerAnnotationNames.Comment] = "Some comment"
//            });
//
//            Assert.Equal(
//                "ALTER TABLE \"dbo\".\"People\" ADD \"foo\" int NOT NULL;" + EOL +
//                "COMMENT ON COLUMN \"dbo\".\"People\".\"foo\" IS 'Some comment';" + EOL,
//                Sql);
        }

        [Fact]
        public override void AddColumnOperation_with_computed_column_SQL()
        {
            base.AddColumnOperation_with_computed_column_SQL();

            Assert.Equal(
                "ALTER TABLE \"People\" ADD \"Birthday\" date NULL;" + EOL,
                Sql);
        }

        [Fact]
        public void AddColumnOperation_with_system_column()
        {
            Generate(new AddColumnOperation
            {
                Table = "foo",
                Schema = "public",
                Name = "xmin"
            });

            Assert.Empty(Sql);
        }

        [Fact]
        public void AlterColumn_change_comment()
        {
            //TODO(benwu): Comment?

//            Generate(
//                new AlterColumnOperation
//                {
//                    Table = "People",
//                    Schema = "dbo",
//                    Name = "LuckyNumber",
//                    ClrType = typeof(int),
//                    ColumnType = "int",
//                    IsNullable = false,
//                    DefaultValue = 7,
//                    OldColumn = new ColumnOperation {[SpannerAnnotationNames.Comment] = "Old comment"},
//                    [SpannerAnnotationNames.Comment] = "New comment"
//                });
//
//            Assert.Equal(
//                @"ALTER TABLE ""dbo"".""People"" ALTER COLUMN ""LuckyNumber"" TYPE int;" + EOL +
//                @"ALTER TABLE ""dbo"".""People"" ALTER COLUMN ""LuckyNumber"" SET NOT NULL;" + EOL +
//                @"ALTER TABLE ""dbo"".""People"" ALTER COLUMN ""LuckyNumber"" SET DEFAULT 7;" + EOL +
//                "COMMENT ON COLUMN \"dbo\".\"People\".\"LuckyNumber\" IS 'New comment'",
//                Sql);
        }

        [Fact]
        public void AlterColumn_remove_comment()
        {
            //TODO(benwu): Comment?

//            Generate(
//                new AlterColumnOperation
//                {
//                    Table = "People",
//                    Schema = "dbo",
//                    Name = "LuckyNumber",
//                    ClrType = typeof(int),
//                    ColumnType = "int",
//                    IsNullable = false,
//                    DefaultValue = 7,
//                    OldColumn = new ColumnOperation {[SpannerAnnotationNames.Comment] = "Old comment"}
//                });
//
//            Assert.Equal(
//                @"ALTER TABLE ""dbo"".""People"" ALTER COLUMN ""LuckyNumber"" TYPE int;" + EOL +
//                @"ALTER TABLE ""dbo"".""People"" ALTER COLUMN ""LuckyNumber"" SET NOT NULL;" + EOL +
//                @"ALTER TABLE ""dbo"".""People"" ALTER COLUMN ""LuckyNumber"" SET DEFAULT 7;" + EOL +
//                "COMMENT ON COLUMN \"dbo\".\"People\".\"LuckyNumber\" IS NULL",
//                Sql);
        }

        [Fact]
        public void AlterColumnOperation_to_serial()
        {
            //TODO(benwu): SerialColumn?

//            Generate(
//                new AlterColumnOperation
//                {
//                    Table = "People",
//                    Name = "IntKey",
//                    ClrType = typeof(int),
//                    ColumnType = "int",
//                    IsNullable = false,
//                    [SpannerAnnotationNames.ValueGenerationStrategy] = SpannerValueGenerationStrategy.SerialColumn
//                });
//
//            Assert.Equal(
//                @"CREATE SEQUENCE ""People_IntKey_seq"" START WITH 1 INCREMENT BY 1 NO MINVALUE NO MAXVALUE NO CYCLE;" +
//                EOL +
//                @"ALTER TABLE ""People"" ALTER COLUMN ""IntKey"" TYPE int;" + EOL +
//                @"ALTER TABLE ""People"" ALTER COLUMN ""IntKey"" SET NOT NULL;" + EOL +
//                @"ALTER TABLE ""People"" ALTER COLUMN ""IntKey"" SET DEFAULT (nextval('""People_IntKey_seq""'));" +
//                EOL +
//                @"ALTER SEQUENCE ""People_IntKey_seq"" OWNED BY ""People"".""IntKey""",
//                Sql);
        }

        [Fact]
        public void AlterColumnOperation_with_defaultValue()
        {
            Generate(
                new AlterColumnOperation
                {
                    Table = "People",
                    Name = "Name",
                    ClrType = typeof(string),
                    MaxLength = 30
                });

            Assert.Equal(
                "ALTER TABLE \"People\" ALTER COLUMN \"Name\" TYPE varchar(30);" + EOL +
                "ALTER TABLE \"People\" ALTER COLUMN \"Name\" SET NOT NULL;" + EOL +
                "ALTER TABLE \"People\" ALTER COLUMN \"Name\" DROP DEFAULT;" + EOL,
                Sql);
        }

        [Fact]
        public void AlterColumnOperation_with_system_column()
        {
            Generate(new AlterColumnOperation
            {
                Table = "foo",
                Schema = "public",
                Name = "xmin",
                ClrType = typeof(int),
                ColumnType = "int",
                IsNullable = false,
                DefaultValue = 7
            });

            Assert.Empty(Sql);
        }

        [Fact]
        public void AlterTable_change_comment()
        {
            //TODO(benwu): Comment?

//            Generate(
//                new AlterTableOperation
//                {
//                    Name = "People",
//                    Schema = "dbo",
//                    OldTable = new Annotatable {[SpannerAnnotationNames.Comment] = "Old comment"},
//                    [SpannerAnnotationNames.Comment] = "New comment"
//                });
//
//            Assert.Equal(
//                "COMMENT ON TABLE \"dbo\".\"People\" IS 'New comment';" + EOL,
//                Sql);
        }

        [Fact]
        public void AlterTable_change_storage_parameters()
        {
            //TODO(benwu): StorageParameterPrefix?

//            Generate(
//                new AlterTableOperation
//                {
//                    Name = "People",
//                    Schema = "dbo",
//                    OldTable = new Annotatable
//                    {
//                        [SpannerAnnotationNames.StorageParameterPrefix + "fillfactor"] = 70,
//                        [SpannerAnnotationNames.StorageParameterPrefix + "user_catalog_table"] = true,
//                        [SpannerAnnotationNames.StorageParameterPrefix + "parallel_workers"] = 8
//                    },
//                    // Add parameter
//                    [SpannerAnnotationNames.StorageParameterPrefix + "autovacuum_enabled"] = true,
//                    // Change parameter
//                    [SpannerAnnotationNames.StorageParameterPrefix + "fillfactor"] = 80,
//                    // Drop parameter user_catalog
//                    // Leave parameter unchanged
//                    [SpannerAnnotationNames.StorageParameterPrefix + "parallel_workers"] = 8
//                });
//
//            Assert.Equal(
//                "ALTER TABLE \"dbo\".\"People\" SET (autovacuum_enabled=true, fillfactor=80);" + EOL +
//                "ALTER TABLE \"dbo\".\"People\" RESET (user_catalog_table);" + EOL,
//                Sql);
        }

        [Fact]
        public void AlterTable_remove_comment()
        {
            //TODO(benwu): Comment?

//            Generate(
//                new AlterTableOperation
//                {
//                    Name = "People",
//                    Schema = "dbo",
//                    OldTable = new Annotatable {[SpannerAnnotationNames.Comment] = "New comment"}
//                });
//            Assert.Equal(
//                "COMMENT ON TABLE \"dbo\".\"People\" IS NULL;" + EOL,
//                Sql);
        }

        [Fact]
        public virtual void CreateDatabaseOperation()
        {
            Generate(new SpannerCreateDatabaseOperation {Name = "northwind"});

            Assert.Equal(
                @"CREATE DATABASE ""northwind"";" + EOL,
                Sql);
        }

        [Fact]
        public void CreateIndexOperation_method()
        {
            //TODO(benwu): IndexMethod?

//            Generate(new CreateIndexOperation
//            {
//                Name = "IX_People_Name",
//                Table = "People",
//                Schema = "dbo",
//                Columns = new[] {"FirstName"},
//                [SpannerAnnotationNames.Prefix + SpannerAnnotationNames.IndexMethod] = "gin"
//            });
//
//            Assert.Equal(
//                "CREATE INDEX \"IX_People_Name\" ON \"dbo\".\"People\" USING gin (\"FirstName\");" + EOL,
//                Sql);
        }

        [Fact]
        public void CreateTableOperation_with_interleave_in_parent()
        {
            //TODO(benwu): InterleaveInParent?

//            var op =
//                new CreateTableOperation
//                {
//                    Name = "People",
//                    Schema = "dbo",
//                    Columns =
//                    {
//                        new AddColumnOperation
//                        {
//                            Name = "Id",
//                            Table = "People",
//                            ClrType = typeof(int),
//                            IsNullable = false
//                        }
//                    },
//                    PrimaryKey = new AddPrimaryKeyOperation
//                    {
//                        Columns = new[] {"Id"}
//                    }
//                };
//
//            var interleaveInParent = new InterleaveInParent(op);
//            interleaveInParent.ParentTableSchema = "my_schema";
//            interleaveInParent.ParentTableName = "my_parent";
//            interleaveInParent.InterleavePrefix = new List<string> {"col_a", "col_b"};
//
//            Generate(op);
//
//            Assert.Equal(
//                "CREATE TABLE \"dbo\".\"People\" (" + EOL +
//                "    \"Id\" int4 NOT NULL," + EOL +
//                "    PRIMARY KEY (\"Id\")" + EOL +
//                ")" + EOL +
//                "INTERLEAVE IN PARENT \"my_schema\".\"my_parent\" (\"col_a\", \"col_b\");" + EOL,
//                Sql);
        }

        [Fact]
        public void CreateTableOperation_with_comment()
        {
            //TODO(benwu): Comment?

//            Generate(
//                new CreateTableOperation
//                {
//                    Name = "People",
//                    Schema = "dbo",
//                    Columns =
//                    {
//                        new AddColumnOperation
//                        {
//                            Name = "Id",
//                            Table = "People",
//                            ClrType = typeof(int),
//                            IsNullable = false
//                        }
//                    },
//                    PrimaryKey = new AddPrimaryKeyOperation
//                    {
//                        Columns = new[] {"Id"}
//                    },
//                    [SpannerAnnotationNames.Comment] = "Some comment"
//                });
//
//            Assert.Equal(
//                "CREATE TABLE \"dbo\".\"People\" (" + EOL +
//                "    \"Id\" int4 NOT NULL," + EOL +
//                "    PRIMARY KEY (\"Id\")" + EOL +
//                ");" + EOL +
//                "COMMENT ON TABLE \"dbo\".\"People\" IS 'Some comment';" + EOL,
//                Sql);
        }

        [Fact]
        public void CreateTableOperation_with_comment_on_column()
        {
            //TODO(benwu): Comment?

//            Generate(
//                new CreateTableOperation
//                {
//                    Name = "People",
//                    Schema = "dbo",
//                    Columns =
//                    {
//                        new AddColumnOperation
//                        {
//                            Name = "Id",
//                            Table = "People",
//                            ClrType = typeof(int),
//                            IsNullable = false,
//                            [SpannerAnnotationNames.Comment] = "Some comment"
//                        }
//                    },
//                    PrimaryKey = new AddPrimaryKeyOperation
//                    {
//                        Columns = new[] {"Id"}
//                    }
//                });
//
//            Assert.Equal(
//                "CREATE TABLE \"dbo\".\"People\" (" + EOL +
//                "    \"Id\" int4 NOT NULL," + EOL +
//                "    PRIMARY KEY (\"Id\")" + EOL +
//                ");" + EOL +
//                "COMMENT ON COLUMN \"dbo\".\"People\".\"Id\" IS 'Some comment';" + EOL,
//                Sql);
        }

        [Fact]
        public void CreateTableOperation_with_storage_parameter()
        {
            //TODO(benwu): StorageParameterPrefix?

//            Generate(
//                new CreateTableOperation
//                {
//                    Name = "People",
//                    Schema = "dbo",
//                    Columns =
//                    {
//                        new AddColumnOperation
//                        {
//                            Name = "Id",
//                            Table = "People",
//                            ClrType = typeof(int),
//                            IsNullable = false
//                        }
//                    },
//                    PrimaryKey = new AddPrimaryKeyOperation
//                    {
//                        Columns = new[] {"Id"}
//                    },
//                    [SpannerAnnotationNames.StorageParameterPrefix + "fillfactor"] = 70,
//                    [SpannerAnnotationNames.StorageParameterPrefix + "user_catalog_table"] = true,
//                    ["some_bogus_name"] = 0
//                });
//
//            Assert.Equal(
//                "CREATE TABLE \"dbo\".\"People\" (" + EOL +
//                "    \"Id\" int4 NOT NULL," + EOL +
//                "    PRIMARY KEY (\"Id\")" + EOL +
//                ")" + EOL +
//                "WITH (fillfactor=70, user_catalog_table=true);" + EOL,
//                Sql);
        }

        [Fact]
        public void CreateTableOperation_with_system_column()
        {
            Generate(new CreateTableOperation
            {
                Name = "foo",
                Schema = "public",
                Columns =
                {
                    new AddColumnOperation
                    {
                        Name = "id",
                        Table = "foo",
                        ClrType = typeof(int),
                        IsNullable = false
                    },
                    new AddColumnOperation
                    {
                        Name = "xmin",
                        Table = "foo",
                        ClrType = typeof(uint),
                        IsNullable = false
                    }
                },
                PrimaryKey = new AddPrimaryKeyOperation
                {
                    Columns = new[] {"id"}
                }
            });

            Assert.Equal(
                "CREATE TABLE \"public\".\"foo\" (" + EOL +
                "    \"id\" int4 NOT NULL," + EOL +
                "    PRIMARY KEY (\"id\")" + EOL +
                ");" + EOL,
                Sql);
        }

        [Fact]
        public void DropColumnOperation_with_system_column()
        {
            Generate(new DropColumnOperation
            {
                Table = "foo",
                Schema = "public",
                Name = "xmin"
            });

            Assert.Empty(Sql);
        }

        [Fact]
        public void EnsurePostgresExtension()
        {
            var op = new AlterDatabaseOperation();
            Generate(op);

            Assert.Equal(
                @"CREATE EXTENSION IF NOT EXISTS ""hstore"";" + EOL,
                Sql);
        }

        [Fact]
        public void RenameIndexOperation()
        {
            Generate(
                new RenameIndexOperation
                {
                    Table = "People",
                    Name = "x",
                    NewName = "y",
                    Schema = "myschema"
                });

            Assert.Equal(
                "ALTER INDEX \"myschema\".\"x\" RENAME TO \"y\";" + EOL,
                Sql);
        }
    }
}