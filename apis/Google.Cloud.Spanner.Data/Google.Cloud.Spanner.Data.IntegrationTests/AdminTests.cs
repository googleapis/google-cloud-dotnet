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

using Google.Cloud.Spanner.Data.CommonTesting;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    // We don't need a database at all in fact - we just need connection strings. This is the
    // easiest way of doing that though (and we can use the database name as a prefix, handily)
    [Collection(nameof(SpannerDatabaseFixture))]
    [CommonTestDiagnostics]
    public class AdminTests
    {
        private readonly SpannerDatabaseFixture _fixture;
        private static int _counter;

        public AdminTests(SpannerDatabaseFixture fixture) =>
            _fixture = fixture;

        private string GenerateDatabaseName() => $"{_fixture.Database.SpannerDatabase}_admin{_counter++}";

        [Fact]
        public async Task CreateDrop()
        {
            string dbName = GenerateDatabaseName();

            using (var connection = new SpannerConnection(_fixture.Database.NoDbConnectionString))
            {
                var createCmd = connection.CreateDdlCommand($"CREATE DATABASE {dbName}");
                await createCmd.ExecuteNonQueryAsync();
            }

            using (var connection = new SpannerConnection(_fixture.Database.NoDbConnectionString))
            {
                var dropCommand = connection.CreateDdlCommand($"DROP DATABASE {dbName}");
                await dropCommand.ExecuteNonQueryAsync();
            }

            // No sessions created, so no session pool.
        }

        [Fact]
        public async Task CreateWithExtrasDrop()
        {
            string dbName = GenerateDatabaseName();
            var builder = new SpannerConnectionStringBuilder(_fixture.Database.NoDbConnectionString);

            using (var connection = new SpannerConnection(builder))
            {
                const string tableCreate = @"CREATE TABLE TX (
                              K                   STRING(MAX) NOT NULL,
                              StringValue         STRING(MAX),
                            ) PRIMARY KEY (K)";

                var createCmd = connection.CreateDdlCommand(
                    $"CREATE DATABASE {dbName}",
                    tableCreate);

                await createCmd.ExecuteNonQueryAsync();
            }

            using (var connection = new SpannerConnection(builder.WithDatabase(dbName)))
            {
                var cmd = connection.CreateInsertCommand("TX", new SpannerParameterCollection
                {
                    {"K", SpannerDbType.String, "key" },
                    {"StringValue", SpannerDbType.String, "value"}
                });
                await cmd.ExecuteNonQueryAsync();
                cmd = connection.CreateSelectCommand("SELECT * FROM TX");
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    await reader.ReadAsync();
                    Assert.Equal("key", reader.GetFieldValue<string>("K"));
                    Assert.Equal("value", reader.GetFieldValue<string>("StringValue"));
                }
            }

            using (var connection = new SpannerConnection(builder))
            {
                var dropCommand = connection.CreateDdlCommand($"DROP DATABASE {dbName}");
                await dropCommand.ExecuteNonQueryAsync();
            }
        }

        [Fact]
        public async Task CreateWithExtrasDrop2()
        {
            string dbName = GenerateDatabaseName();
            var builder = new SpannerConnectionStringBuilder(_fixture.Database.NoDbConnectionString);

            using (var connection = new SpannerConnection(builder))
            {
                var createCmd = connection.CreateDdlCommand(
                    $"CREATE DATABASE {dbName}");

                await createCmd.ExecuteNonQueryAsync();
            }

            using (var connection = new SpannerConnection(builder.WithDatabase(dbName)))
            {
                const string tableCreate1 = @"CREATE TABLE TX1 (
                              K                   STRING(MAX) NOT NULL,
                              StringValue         STRING(MAX),
                            ) PRIMARY KEY (K)";
                const string tableCreate2 = @"CREATE TABLE TX2 (
                              K                   STRING(MAX) NOT NULL,
                              StringValue         STRING(MAX),
                            ) PRIMARY KEY (K)";
                var updateCmd = connection.CreateDdlCommand(tableCreate1, tableCreate2);
                await updateCmd.ExecuteNonQueryAsync();

                var cmd = connection.CreateInsertCommand("TX2", new SpannerParameterCollection
                {
                    {"K", SpannerDbType.String, "key" },
                    {"StringValue", SpannerDbType.String, "value"}
                });
                await cmd.ExecuteNonQueryAsync();
                cmd = connection.CreateSelectCommand("SELECT * FROM TX2");
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    await reader.ReadAsync();
                    Assert.Equal("key", reader.GetFieldValue<string>("K"));
                    Assert.Equal("value", reader.GetFieldValue<string>("StringValue"));
                }
            }

            using (var connection = new SpannerConnection(builder))
            {
                var dropCommand = connection.CreateDdlCommand($"DROP DATABASE {dbName}");
                await dropCommand.ExecuteNonQueryAsync();
            }
        }

        [Fact]
        public async Task DropDoesntSupportExtra()
        {
            string dbName = GenerateDatabaseName();
            using (var connection = new SpannerConnection(_fixture.Database.NoDbConnectionString))
            {
                var createCmd = connection.CreateDdlCommand(
                    $"CREATE DATABASE {dbName}");
                await createCmd.ExecuteNonQueryAsync();
            }

            using (var connection = new SpannerConnection(_fixture.Database.NoDbConnectionString))
            {
                const string tableCreate1 = @"CREATE TABLE TX1 (
                              K                   STRING(MAX) NOT NULL,
                              StringValue         STRING(MAX),
                            ) PRIMARY KEY (K)";

                var dropCommand = connection.CreateDdlCommand($"DROP DATABASE {dbName}", tableCreate1);
                await Assert.ThrowsAsync<InvalidOperationException>(() => dropCommand.ExecuteNonQueryAsync());
                dropCommand = connection.CreateDdlCommand($"DROP DATABASE {dbName}");
                await dropCommand.ExecuteNonQueryAsync();
            }
        }

        // This is just one example of DDL that isn't create/drop database.
        [Fact]
        public async Task CreateTableRequiresDatabase()
        {
            using (var connection = new SpannerConnection(_fixture.Database.NoDbConnectionString))
            {
                var cmd = connection.CreateDdlCommand("CREATE TABLE FOO(K STRING(MAX) NOT NULL) PRIMARY KEY (K)");
                await Assert.ThrowsAsync<InvalidOperationException>(() => cmd.ExecuteNonQueryAsync());
            }
        }

        [Fact]
        public async Task CreateReturnsErrors()
        {
            string dbName = GenerateDatabaseName();

            using (var connection = new SpannerConnection(_fixture.Database.NoDbConnectionString))
            {
                var createCmd = connection.CreateDdlCommand($"CREATE DATABASE Bad-Name");
                await Assert.ThrowsAsync<SpannerException>(() => createCmd.ExecuteNonQueryAsync());
                createCmd = connection.CreateDdlCommand($"CREATE DATABASE {dbName}");
                await createCmd.ExecuteNonQueryAsync();

                //calling again should throw an error.
                await Assert.ThrowsAsync<SpannerException>(() => createCmd.ExecuteNonQueryAsync());

                var dropCmd = connection.CreateDdlCommand($"DROP DATABASE {dbName}");
                await dropCmd.ExecuteNonQueryAsync();
            }
        }

        [Fact]
        public async Task DdlCommandReturnsErrors()
        {
            string dbName = GenerateDatabaseName();
            var builder = new SpannerConnectionStringBuilder(_fixture.Database.NoDbConnectionString);

            using (var connection = new SpannerConnection(builder))
            {
                const string tableSingers = @"
                        CREATE TABLE Singers (
                          SingerId INT64 NOT NULL,
                          FirstName STRING(1024),
                          LastName STRING(1024),
                          ComposerInfo BYTES(MAX),
                        ) PRIMARY KEY(SingerId)";

                const string tableAlbums = @"CREATE TABLE Albums (
                      SingerId INT64 NOT NULL,
                      AlbumId INT64 NOT NULL,
                      AlbumTitle STRING(MAX),
                    ) PRIMARY KEY(SingerId, AlbumId),
                      INTERLEAVE IN PARENT Singers ON DELETE CASCADE";

                var createCmd = connection.CreateDdlCommand(
                    $"CREATE DATABASE {dbName}",
                    tableSingers, tableAlbums);

                await createCmd.ExecuteNonQueryAsync();
            }

            using (var connection = new SpannerConnection(builder.WithDatabase(dbName)))
            {
                var dropSingersCmd = connection.CreateDdlCommand("DROP TABLE Singers");
                var dropAlbumsCmd = connection.CreateDdlCommand("DROP TABLE Albums");

                await Assert.ThrowsAsync<SpannerException>(() => dropSingersCmd.ExecuteNonQueryAsync());
                await dropAlbumsCmd.ExecuteNonQueryAsync();
                await dropSingersCmd.ExecuteNonQueryAsync();
            }

            using (var connection = new SpannerConnection(builder))
            {
                var dropCommand = connection.CreateDdlCommand($"DROP DATABASE {dbName}");
                await dropCommand.ExecuteNonQueryAsync();
            }
        }
    }
}
