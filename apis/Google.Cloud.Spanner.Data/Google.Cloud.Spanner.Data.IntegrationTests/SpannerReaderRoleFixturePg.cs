// Copyright 2023 Google LLC
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

[CollectionDefinition(nameof(SpannerReaderRoleFixturePg))]
public class SpannerReaderRoleFixturePg : SpannerTableFixturePostgreSql, ICollectionFixture<SpannerReaderRoleFixturePg>
{
    public const string ReaderDatabaseRole = "PgReader";

    public SpannerReaderRoleFixturePg(): base("PgDbRoleTable")
    {
    }
    protected override void CreateTable()
    {
        string tableCreate = $"CREATE TABLE {TableName}( K VARCHAR(4096) NOT NULL PRIMARY KEY, StringValue TEXT)";
        ExecuteDdl(tableCreate);
        CreateDatabaseRoleAndGrantAccess();
    }

    protected override void PopulateTable(bool fresh)
    {
        if (fresh)
        {
            using var connection = GetConnection();
            using var insertCmd = connection.CreateInsertCommand(TableName,new SpannerParameterCollection
            {
                { "K", SpannerDbType.String, "key" },
                { "StringValue", SpannerDbType.String, "value" }
            });
            insertCmd.ExecuteNonQuery();
        }
    }

    private void CreateDatabaseRoleAndGrantAccess()
    {
        using var connection = GetConnection();
        string databaseRoleCreate = $"CREATE ROLE {ReaderDatabaseRole}";
        string databaseRoleGrant = $"GRANT SELECT ON TABLE {TableName} TO {ReaderDatabaseRole}";
        using var createCmd = connection.CreateDdlCommand(databaseRoleCreate, databaseRoleGrant);
        createCmd.ExecuteNonQuery();
    }

    public SpannerConnection GetReadOnlyConnection() =>
        new SpannerConnection(new SpannerConnectionStringBuilder
        {
            DatabaseName = DatabaseName,
            DatabaseRole = ReaderDatabaseRole
        });
}
