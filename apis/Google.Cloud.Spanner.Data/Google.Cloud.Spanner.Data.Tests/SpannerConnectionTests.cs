// Copyright 2018 Google LLC
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

using Google.Apis.Auth.OAuth2;
using Google.Apis.Http;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Grpc.Core;
using Grpc.Auth;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests
{
    public partial class SpannerConnectionTests
    {
        [Fact]
        public void GetSchema_ExposesCommonCollections()
        {
            using var connection = new SpannerConnection("Data Source=projects/p/instances/i/databases/d");

            var collections = connection.GetSchema();
            Assert.Equal("MetaDataCollections", collections.TableName);
            Assert.Equal(5, collections.Rows.Count);
            foreach (var row in collections.Rows.Cast<System.Data.DataRow>())
            {
                Assert.Equal(0, row.Field<int>("NumberOfRestrictions"));
                Assert.Equal(0, row.Field<int>("NumberOfIdentifierParts"));
            }

            foreach (var name in new[] { "MetaDataCollections", "DataSourceInformation", "Restrictions" })
            {
                Assert.Equal(name, connection.GetSchema(name).TableName);
                Assert.Equal(name, connection.GetSchema(name.ToLowerInvariant()).TableName);
                Assert.Equal(name, connection.GetSchema(name.ToUpperInvariant()).TableName);
                Assert.Equal(name, connection.GetSchema(name, Array.Empty<string>()).TableName);
            }

            // Dialect-specific metadata requires an open database connection;
            // a connection string alone does not disclose the database dialect.
            foreach (var name in new[] { "DataTypes", "ReservedWords" })
            {
                Assert.Throws<InvalidOperationException>(() => connection.GetSchema(name));
                Assert.Throws<InvalidOperationException>(() => connection.GetSchema(name.ToUpperInvariant()));
            }

            foreach (var name in new[] { "MetaDataCollections", "DataSourceInformation",
                         "DataTypes", "Restrictions", "ReservedWords" })
            {
                var exception = Assert.Throws<ArgumentException>(
                    () => connection.GetSchema(name, new[] { "restriction" }));
                Assert.Equal("restrictionValues", exception.ParamName);
                Assert.Contains("Restrictions are not supported for the requested schema collection.", exception.Message);
            }
        }

        [Fact]
        public void GetSchema_DataSourceInformation_ReportsProduct()
        {
            using var connection = new SpannerConnection("Data Source=projects/p/instances/i/databases/d");
            var schema = connection.GetSchema("DataSourceInformation");

            Assert.Single(schema.Rows);
            Assert.Equal("Google Cloud Spanner", schema.Rows[0]["DataSourceProductName"]);
            Assert.Equal(connection.ServerVersion, schema.Rows[0]["DataSourceProductVersion"]);
            Assert.Equal("@{0}", schema.Rows[0]["ParameterMarkerFormat"]);
            Assert.Equal(";", schema.Rows[0]["StatementSeparatorPattern"]);
        }

        [Theory]
        [InlineData(false, "INT64", "STRING", "JSON")]
        [InlineData(true, "bigint", "character varying", "jsonb")]
        public void GetSchema_DataTypes_UsesCorrectSqlDialect(bool postgreSql, string numeric,
            string text, string json)
        {
            var table = SpannerSchema.GetDataTypes(postgreSql);
            Assert.True(table.Rows.Count >= 12);
            Assert.Contains(table.Rows.Cast<System.Data.DataRow>(), row => (string)row["TypeName"] == numeric);
            Assert.Contains(table.Rows.Cast<System.Data.DataRow>(), row => (string)row["TypeName"] == text);
            Assert.Contains(table.Rows.Cast<System.Data.DataRow>(), row => (string)row["TypeName"] == json);
            Assert.All(table.Rows.Cast<System.Data.DataRow>(), row =>
            {
                Assert.NotEqual(DBNull.Value, row["DataType"]);
                Assert.NotEqual(DBNull.Value, row["CreateFormat"]);
                // No numeric enum is exposed for SpannerDbType; never substitute DbType.
                Assert.Equal(DBNull.Value, row["ProviderDbType"]);
            });
        }

        [Theory]
        [InlineData(false, "ASSERT_ROWS_MODIFIED")]
        [InlineData(true, "CONCURRENTLY")]
        public void GetSchema_ReservedWords_UsesCorrectSqlDialect(bool postgreSql, string keyword)
        {
            var table = SpannerSchema.GetReservedWords(postgreSql);
            Assert.True(table.Rows.Count > 75);
            Assert.Contains(table.Rows.Cast<System.Data.DataRow>(), row =>
                (string)row["ReservedWord"] == keyword);
            Assert.DoesNotContain(table.Rows.Cast<System.Data.DataRow>(), row =>
                (string)row["ReservedWord"] == "NOT_A_KEYWORD");
        }

        [Fact]
        public void OpenWithNoDatabase_InvalidCredentials()
        {
            var builder = new SpannerConnectionStringBuilder
            {
                DataSource = "projects/project_id/instances/instance_id",
                CredentialFile = "this_will_not_exist.json"
            };
            using (var connection = new SpannerConnection(builder))
            {
                Assert.Throws<FileNotFoundException>(() => connection.Open());
            }
        }

        [Fact]
        public void ConnectionString_SetterMaintainsChannelCredentialsAndSessionPoolManager()
        {
            var channelCredentials = new FakeCredential().ToChannelCredentials();
            var sessionPoolManager = new SessionPoolManager(new SessionPoolOptions(), SpannerSettings.GetDefault(), Logger.DefaultLogger, (o, s) => throw new InvalidOperationException());

            var builder = new SpannerConnectionStringBuilder("Data Source=projects/project_id/instances/instance_id; ClrToSpannerTypeDefaultMappings=DecimalToNumeric", channelCredentials)
            {
                SessionPoolManager = sessionPoolManager
            };
            using var connection = new SpannerConnection(builder);
            connection.ConnectionString = "Data Source=projects/project_id2/instances/instance_id2; ClrToSpannerTypeDefaultMappings=DecimalToPgNumeric";

            // Original builder hasn't changed
            Assert.Equal("projects/project_id/instances/instance_id", builder.DataSource);
            Assert.Equal(SpannerDbType.Numeric, builder.ConversionOptions.DecimalToConfiguredSpannerType);

            // Connection observes new values
            Assert.Equal("projects/project_id2/instances/instance_id2", connection.DataSource);
            Assert.Equal(SpannerDbType.PgNumeric, connection.Builder.ConversionOptions.DecimalToConfiguredSpannerType);

            Assert.Same(channelCredentials, connection.Builder.CredentialOverride);
            Assert.Same(sessionPoolManager, connection.Builder.SessionPoolManager);
        }

        [Fact]
        public void Constructor_GoogleCredential()
        {
            var credential = GoogleCredential.FromAccessToken("token", accessMethod: null);
            var connection = new SpannerConnection("Data Source=projects/project_id/instances/instance_id", credential);
            Assert.Same(credential, connection.Builder.GoogleCredential);
        }

        private class FakeCredential : ITokenAccess
        {
            public Task<string> GetAccessTokenForRequestAsync(string authUri = null, CancellationToken cancellationToken = default) =>
                throw new NotImplementedException();
        }
    }
}
