// Copyright 2016 Google Inc. All Rights Reserved.
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

using Google.Apis.Bigquery.v2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.BigQuery.V2.IntegrationTests
{
    [Collection(nameof(BigQueryFixture))]
    public class SqlCommandTest
    {
        private const string PublicDatasetsProject = "bigquery-public-data";
        private const string PublicDatasetsDataset = "samples";
        private const string ShakespeareTable = "shakespeare";
        private readonly BigQueryFixture _fixture;

        public SqlCommandTest(BigQueryFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public async Task SynchronousTemporaryQueryAsync()
        {
            // You must always place the datasource from which reads will execute in the connection string.
            // In this case, since we only read from temp tables, we can exclude the dataset.
            using (var connection = new BigQueryConnection($"Data Source=projects/{_fixture.ProjectId}"))
            {
                await connection.OpenAsync();

                var table = connection.GetTable(PublicDatasetsProject, PublicDatasetsDataset, ShakespeareTable);
                var sql = $"SELECT corpus as title, COUNT(word) as unique_words FROM {table} GROUP BY title ORDER BY unique_words DESC LIMIT 10";

                using (var sqlCmd = connection.CreateSqlCommand(sql))
                using (var reader = await sqlCmd.ExecuteReaderAsync())
                {
                    var rows = 0;
                    while (await reader.ReadAsync())
                    {
                        if (rows == 0)
                        {
                            Assert.Equal("hamlet", reader.GetFieldValue<string>("title"));
                            Assert.Equal(5318, reader.GetFieldValue<long>("unique_words"));
                        }
                        rows++;
                    }
                    Assert.Equal(10, rows);
                }
            }
        }

        [Fact]
        public async Task AsynchronousTemporaryQueryAsync()
        {
            // You must always place the datasource from which reads will execute in the connection string.
            // In this case, since we only read from temp tables, we can exclude the dataset.
            using (var connection = new BigQueryConnection($"Data Source=projects/{_fixture.ProjectId}"))
            {
                await connection.OpenAsync();

                var table = connection.GetTable(PublicDatasetsProject, PublicDatasetsDataset, ShakespeareTable);
                var sql = $"SELECT corpus as title, COUNT(word) as unique_words FROM {table} GROUP BY title ORDER BY unique_words DESC LIMIT 10";

                using (var sqlCmd = connection.CreateSqlCommand(sql))
                {
                    var job = await sqlCmd.StartJobAsync();
                    var result = await job.GetQueryResultsAsync();
                    using (var reader = result.GetDataReader())
                    {
                        var rows = 0;
                        while (await reader.ReadAsync())
                        {
                            if (rows == 0)
                            {
                                Assert.Equal("hamlet", reader.GetFieldValue<string>("title"));
                                Assert.Equal(5318, reader.GetFieldValue<long>("unique_words"));
                            }
                            rows++;
                        }
                        Assert.Equal(10, rows);
                    }
                }
            }
        }

        [Fact]
        public async Task AsynchronousPermanentQueryAsync()
        {
            using (var connection = new BigQueryConnection($"Data Source=projects/{_fixture.ProjectId}/datasets/{_fixture.DatasetId}"))
            {
                await connection.OpenAsync();

                var table = connection.GetTable(PublicDatasetsProject, PublicDatasetsDataset, ShakespeareTable);
                var sql = $"SELECT corpus as title, COUNT(word) as unique_words FROM {table} GROUP BY title ORDER BY unique_words DESC LIMIT 10";
                var destinationTable = connection.GetTableReference(_fixture.CreateTableId());

                using (var sqlCmd =
                    connection.CreateSqlCommand(sql, new QueryOptions {DestinationTable = destinationTable}))
                using (var reader = await sqlCmd.ExecuteReaderAsync())
                {
                    var rows = 0;
                    while (await reader.ReadAsync())
                    {
                        if (rows == 0)
                        {
                            Assert.Equal("hamlet", reader.GetFieldValue<string>("title"));
                            Assert.Equal(5318, reader.GetFieldValue<long>("unique_words"));
                        }
                        rows++;
                    }
                    Assert.Equal(10, rows);
                }

                using (var sqlCmd =
                    connection.CreateSqlCommand($"SELECT * FROM {destinationTable.TableId} ORDER BY unique_words DESC"))
                using (var reader = await sqlCmd.ExecuteReaderAsync())
                {
                    var rows = 0;
                    while (await reader.ReadAsync())
                    {
                        if (rows == 0)
                        {
                            Assert.Equal("hamlet", reader.GetFieldValue<string>("title"));
                            Assert.Equal(5318, reader.GetFieldValue<long>("unique_words"));
                        }
                        rows++;
                    }
                    Assert.Equal(10, rows);
                }
            }
        }

        [Fact]
        public async Task RepeatedFields_AggregateAsync()
        {
            using (var connection = new BigQueryConnection($"Data Source=projects/{_fixture.ProjectId}/datasets/{_fixture.DatasetId}"))
            {
                await connection.OpenAsync();

                var sql = $"SELECT fullName, ARRAY_LENGTH(children) AS childCount FROM {_fixture.PeopleTableId} ORDER BY fullName";
                using (var sqlCmd = connection.CreateSqlCommand(sql))
                using (var reader = await sqlCmd.ExecuteReaderAsync())
                {
                    var results = new List<object>();
                    while (await reader.ReadAsync())
                    {
                        results.Add(new
                        {
                            Name = reader.GetFieldValue<string>("fullName"),
                            Count = reader.GetFieldValue<long>("childCount")
                        });
                    }
                    object[] expectedResults = {
                        new { Name = "Anna Karenina", Count = 0L },
                        new { Name = "John Doe", Count = 2L },
                        new { Name = "Mike Jones", Count = 3L },
                    };
                    Assert.Equal(expectedResults, results.ToArray());
                }
            }
        }

        [Fact]
        public async Task RepeatedFields_FlatteningAsync()
        {
            using (var connection = new BigQueryConnection($"Data Source=projects/{_fixture.ProjectId}/datasets/{_fixture.DatasetId}"))
            {
                await connection.OpenAsync();

                var sql = $"SELECT fullName, child.name AS childName FROM {_fixture.PeopleTableId} LEFT JOIN UNNEST(children) AS child ORDER BY fullName, childName";
                using (var sqlCmd = connection.CreateSqlCommand(sql))
                using (var reader = await sqlCmd.ExecuteReaderAsync())
                {
                    var results = new List<object>();
                    while (await reader.ReadAsync())
                    {
                        results.Add(new
                        {
                            Name = reader.GetFieldValue<string>("fullName"),
                            Child = reader.GetFieldValue<string>("childName")
                        });
                    }
                    object[] expectedResults = {
                        new { Name = "Anna Karenina", Child = (string) null },
                        new { Name = "John Doe", Child = "Jane" },
                        new { Name = "John Doe", Child = "John" },
                        new { Name = "Mike Jones", Child = "Earl" },
                        new { Name = "Mike Jones", Child = "Kit" },
                        new { Name = "Mike Jones", Child = "Sam" }
                    };
                    Assert.Equal(expectedResults, results.ToArray());
                }
            }
        }

        [Fact]
        public async Task RecordFieldAsync()
        {
            using (var connection = new BigQueryConnection($"Data Source=projects/{_fixture.ProjectId}/datasets/{_fixture.DatasetId}"))
            {
                await connection.OpenAsync();

                var sql = $"SELECT fullName, phoneNumber.areaCode, phoneNumber.number FROM {_fixture.PeopleTableId} ORDER BY fullName";
                using (var sqlCmd = connection.CreateSqlCommand(sql))
                using (var reader = await sqlCmd.ExecuteReaderAsync())
                {
                    var results = new List<object>();
                    while (await reader.ReadAsync())
                    {
                        results.Add(new
                        {
                            Name = reader.GetFieldValue<string>("fullName"),
                            AreaCode = reader.GetFieldValue<long>("areaCode"),
                            Number = reader.GetFieldValue<long>("number")
                        });
                    }
                    object[] expectedResults = {
                        new { Name = "Anna Karenina", AreaCode = 425L, Number = 1984783L },
                        new { Name = "John Doe", AreaCode = 206L, Number = 1234567L },
                        new { Name = "Mike Jones", AreaCode = 622L, Number = 1567845L }
                    };
                    Assert.Equal(expectedResults, results.ToArray());
                }
            }
        }

        [Fact]
        public async Task MultiRequestQueryStreamingAsync()
        {
            using (var connection = new BigQueryConnection($"Data Source=projects/{_fixture.ProjectId}/datasets/{_fixture.DatasetId}"))
            {
                await connection.OpenAsync();

                using (var sqlCmd = connection.CreateSqlCommand($"SELECT * FROM {_fixture.HighScoreTableId}",
                    resultsOptions: new GetQueryResultsOptions { PageSize = 1 }))
                using (var reader = await sqlCmd.ExecuteReaderAsync())
                {
                    var rowCount = 0;
                    while (await reader.ReadAsync())
                    {
                        rowCount ++;
                    }
                    Assert.True(rowCount >= 2);
                }
            }
        }

        [Fact]
        public async Task EmptyQueryResults_ExecuteQueryAsync()
        {
            using (var connection = new BigQueryConnection($"Data Source=projects/{_fixture.ProjectId}/datasets/{_fixture.DatasetId}"))
            {
                await connection.OpenAsync();

                using (var sqlCmd = connection.CreateSqlCommand($"SELECT * FROM {_fixture.HighScoreTableId} WHERE score < 0"))
                using (var reader = await sqlCmd.ExecuteReaderAsync())
                {
                    var rowCount = 0;
                    while (await reader.ReadAsync())
                    {
                        rowCount++;
                    }
                    Assert.Equal(0, rowCount);
                }
            }
        }

        [Fact]
        public async Task EmptyQueryResults_CreateQueryJobAsync()
        {
            using (var connection = new BigQueryConnection($"Data Source=projects/{_fixture.ProjectId}/datasets/{_fixture.DatasetId}"))
            {
                await connection.OpenAsync();

                using (var sqlCmd = connection.CreateSqlCommand($"SELECT * FROM {_fixture.HighScoreTableId} WHERE score < 0"))
                {
                    var job = await sqlCmd.StartJobAsync();
                    var results = await job.GetQueryResultsAsync();
                    Assert.Empty(results.ToList());
                }
            }
        }

        [Fact]
        public async Task EmptyQueryResults_ReadPageAsync()
        {
            using (var connection = new BigQueryConnection($"Data Source=projects/{_fixture.ProjectId}/datasets/{_fixture.DatasetId}"))
            {
                await connection.OpenAsync();

                using (var sqlCmd = connection.CreateSqlCommand($"SELECT * FROM {_fixture.HighScoreTableId} WHERE score < 0",
                  resultsOptions: new GetQueryResultsOptions { PageSize = 100 }))
                {
                    var job = await sqlCmd.StartJobAsync();
                    var results = await job.GetQueryResultsAsync();
                    var page10 = await results.ReadPageAsync(10);
                    Assert.Empty(page10.Rows);
                }
            }
        }

        [Fact]
        public async Task SimpleTypesAsync()
        {
            using (var connection = new BigQueryConnection($"Data Source=projects/{_fixture.ProjectId}/datasets/{_fixture.DatasetId}"))
            {
                await connection.OpenAsync();

                using (var sqlCmd = connection.CreateSqlCommand($@"SELECT
                            'Hello' AS String,
                            b'Hello' AS Bytes,
                            TRUE AS Boolean,
                            1234567890 AS Int64,
                            1.234567 AS Float64,
                            DATE '2016-11-29' AS Date,
                            TIME '12:34:56.123456' AS Time,
                            DATETIME '2016-11-29 12:34:56.123456' AS DateTime,
                            TIMESTAMP '2016-11-29 12:34:56.123456' AS Timestamp"))
                using (var reader = await sqlCmd.ExecuteReaderAsync())
                {
                    var rowCount = 0;
                    while (await reader.ReadAsync())
                    {
                        Assert.Equal("Hello", reader.GetFieldValue<string>("String"));
                        Assert.Equal("Hello", reader["String"]);
                        Assert.Equal(Encoding.UTF8.GetBytes("Hello"), reader.GetFieldValue<byte[]>("Bytes"));
                        Assert.Equal(Encoding.UTF8.GetBytes("Hello"), reader["Bytes"]);
                        Assert.Equal(true, reader.GetFieldValue<bool>("Boolean"));
                        Assert.Equal(true, reader["Boolean"]);
                        Assert.Equal(1234567890L, reader.GetFieldValue<long>("Int64"));
                        Assert.Equal(1234567890L, reader["Int64"]);
                        Assert.Equal(1.234567, reader.GetFieldValue<double>("Float64"));
                        Assert.Equal(1.234567, reader["Float64"]);
                        Assert.Equal(new DateTime(2016, 11, 29, 0, 0, 0, DateTimeKind.Unspecified), reader.GetFieldValue<DateTime>("Date"));
                        Assert.Equal(new DateTime(2016, 11, 29, 0, 0, 0, DateTimeKind.Unspecified), reader["Date"]);
                        // There are 10 ticks per microsecond.
                        Assert.Equal(new TimeSpan(0, 12, 34, 56, 123) + TimeSpan.FromTicks(4560), reader.GetFieldValue<TimeSpan>("Time"));
                        Assert.Equal(new TimeSpan(0, 12, 34, 56, 123) + TimeSpan.FromTicks(4560), reader["Time"]);
                        Assert.Equal(new DateTime(2016, 11, 29, 12, 34, 56, 123, DateTimeKind.Unspecified) + TimeSpan.FromTicks(4560), reader.GetFieldValue<DateTime>("DateTime"));
                        Assert.Equal(new DateTime(2016, 11, 29, 12, 34, 56, 123, DateTimeKind.Unspecified) + TimeSpan.FromTicks(4560), reader["DateTime"]);
                        Assert.Equal(new DateTime(2016, 11, 29, 12, 34, 56, 123, DateTimeKind.Utc) + TimeSpan.FromTicks(4560), reader.GetFieldValue<DateTime>("Timestamp"));
                        Assert.Equal(new DateTime(2016, 11, 29, 12, 34, 56, 123, DateTimeKind.Utc) + TimeSpan.FromTicks(4560), reader["Timestamp"]);

                        // Double-check the kinds here...
                        Assert.Equal(DateTimeKind.Unspecified, reader.GetFieldValue<DateTime>("DateTime").Kind);
                        Assert.Equal(DateTimeKind.Utc, reader.GetFieldValue<DateTime>("Timestamp").Kind);
                        rowCount++;
                    }
                    Assert.Equal(1, rowCount);
                }
            }
        }

        [Fact]
        public async Task ArrayTypesAsync()
        {
            using (var connection = new BigQueryConnection($"Data Source=projects/{_fixture.ProjectId}/datasets/{_fixture.DatasetId}"))
            {
                await connection.OpenAsync();

                using (var sqlCmd = connection.CreateSqlCommand($@"SELECT
                            ['Hello'] AS String,
                            [b'Hello'] AS Bytes,
                            [TRUE] AS Boolean,
                            [1234567890] AS Int64,
                            [1.234567] AS Float64,
                            [DATE '2016-11-29'] AS Date,
                            [TIME '12:34:56.123456'] AS Time,
                            [DATETIME '2016-11-29 12:34:56.123456'] AS DateTime,
                            [TIMESTAMP '2016-11-29 12:34:56.123456'] AS Timestamp"))
                using (var reader = await sqlCmd.ExecuteReaderAsync())
                {
                    var rowCount = 0;
                    while (await reader.ReadAsync())
                    {
                        Assert.Equal(new[] { "Hello" }, reader.GetFieldValue<string[]>("String"));
                        Assert.Equal(new[] { "Hello" }, reader["String"]);
                        Assert.Equal(new[] { Encoding.UTF8.GetBytes("Hello") }, reader.GetFieldValue<byte[][]>("Bytes"));
                        Assert.Equal(new[] { Encoding.UTF8.GetBytes("Hello") }, reader["Bytes"]);
                        Assert.Equal(new[] { true }, reader.GetFieldValue<bool[]>("Boolean"));
                        Assert.Equal(new[] { true }, reader["Boolean"]);
                        Assert.Equal(new[] { 1234567890L }, reader.GetFieldValue<long[]>("Int64"));
                        Assert.Equal(new[] { 1234567890L }, reader["Int64"]);
                        Assert.Equal(new[] { 1.234567 }, reader.GetFieldValue<double[]>("Float64"));
                        Assert.Equal(new[] { 1.234567 }, reader["Float64"]);
                        Assert.Equal(new[] { new DateTime(2016, 11, 29, 0, 0, 0, DateTimeKind.Unspecified) }, reader.GetFieldValue<DateTime[]>("Date"));
                        Assert.Equal(new[] { new DateTime(2016, 11, 29, 0, 0, 0, DateTimeKind.Unspecified) }, reader["Date"]);
                        // There are 10 ticks per microsecond.
                        Assert.Equal(new[] { new TimeSpan(0, 12, 34, 56, 123) + TimeSpan.FromTicks(4560) }, reader.GetFieldValue<TimeSpan[]>("Time"));
                        Assert.Equal(new[] { new TimeSpan(0, 12, 34, 56, 123) + TimeSpan.FromTicks(4560) }, reader["Time"]);
                        Assert.Equal(new[] { new DateTime(2016, 11, 29, 12, 34, 56, 123, DateTimeKind.Unspecified) + TimeSpan.FromTicks(4560) }, reader.GetFieldValue<DateTime[]>("DateTime"));
                        Assert.Equal(new[] { new DateTime(2016, 11, 29, 12, 34, 56, 123, DateTimeKind.Unspecified) + TimeSpan.FromTicks(4560) }, reader["DateTime"]);
                        Assert.Equal(new[] { new DateTime(2016, 11, 29, 12, 34, 56, 123, DateTimeKind.Utc) + TimeSpan.FromTicks(4560) }, reader.GetFieldValue<DateTime[]>("Timestamp"));
                        Assert.Equal(new[] { new DateTime(2016, 11, 29, 12, 34, 56, 123, DateTimeKind.Utc) + TimeSpan.FromTicks(4560) }, reader["Timestamp"]);

                        // Double-check the kinds here...
                        Assert.Equal(DateTimeKind.Unspecified, reader.GetFieldValue<DateTime[]>("DateTime")[0].Kind);
                        Assert.Equal(DateTimeKind.Utc, reader.GetFieldValue<DateTime[]>("Timestamp")[0].Kind);
                        rowCount++;
                    }
                    Assert.Equal(1, rowCount);
                }
            }
        }

        [Fact]
        public async Task StructTypesAsync()
        {
            using (var connection = new BigQueryConnection($"Data Source=projects/{_fixture.ProjectId}/datasets/{_fixture.DatasetId}"))
            {
                await connection.OpenAsync();

                using (var sqlCmd = connection.CreateSqlCommand($@"
                        SELECT ('Hello', b'Hello', TRUE, 1234567890, 1.234567, DATE '2016-11-29',
                            TIME '12:34:56.123456', DATETIME '2016-11-29 12:34:56.123456',
                            TIMESTAMP '2016-11-29 12:34:56.123456') AS value"))
                using (var reader = await sqlCmd.ExecuteReaderAsync())
                {
                    var rowCount = 0;
                    while (await reader.ReadAsync())
                    {
                        // Structs come back as dictionaries, as if they're records.
                        var values = (Dictionary<string, object>)reader["value"];
                        Assert.Equal("Hello", values["_field_1"]);
                        Assert.Equal(Encoding.UTF8.GetBytes("Hello"), values["_field_2"]);
                        Assert.Equal(true, values["_field_3"]);
                        Assert.Equal(1234567890L, values["_field_4"]);
                        Assert.Equal(1.234567, values["_field_5"]);
                        Assert.Equal(new DateTime(2016, 11, 29, 0, 0, 0, DateTimeKind.Unspecified), values["_field_6"]);
                        // There are 10 ticks per microsecond.
                        Assert.Equal(new TimeSpan(0, 12, 34, 56, 123) + TimeSpan.FromTicks(4560), values["_field_7"]);
                        Assert.Equal(new DateTime(2016, 11, 29, 12, 34, 56, 123) + TimeSpan.FromTicks(4560), values["_field_8"]);
                        Assert.Equal(new DateTime(2016, 11, 29, 12, 34, 56, 123, DateTimeKind.Utc) + TimeSpan.FromTicks(4560), values["_field_9"]);

                        // Double-check the kinds here...
                        Assert.Equal(DateTimeKind.Unspecified, ((DateTime)values["_field_8"]).Kind);
                        Assert.Equal(DateTimeKind.Utc, ((DateTime)values["_field_9"]).Kind);
                        
                        rowCount++;
                    }
                    Assert.Equal(1, rowCount);
                }
            }
        }

        [Fact]
        public async Task NullStructValueAsync()
        {
            using (var connection = new BigQueryConnection($"Data Source=projects/{_fixture.ProjectId}/datasets/{_fixture.DatasetId}"))
            {
                await connection.OpenAsync();

                using (var sqlCmd = connection.CreateSqlCommand("SELECT STRUCT<x string>(NULL) AS s"))
                using (var reader = await sqlCmd.ExecuteReaderAsync())
                {
                    var rowCount = 0;
                    while (await reader.ReadAsync())
                    {
                        var s = (Dictionary<string, object>)reader["s"];
                        Assert.Null(s["x"]);

                        rowCount++;
                    }
                    Assert.Equal(1, rowCount);
                }
            }
        }

        [Fact]
        public async Task StringValueThatLooksLikeADateAsync()
        {
            using (var connection = new BigQueryConnection($"Data Source=projects/{_fixture.ProjectId}/datasets/{_fixture.DatasetId}"))
            {
                await connection.OpenAsync();

                using (var sqlCmd = connection.CreateSqlCommand("SELECT '2017-05-04T15:01:00Z' AS value"))
                using (var reader = await sqlCmd.ExecuteReaderAsync())
                {
                    var rowCount = 0;
                    while (await reader.ReadAsync())
                    {
                        Assert.Equal("2017-05-04T15:01:00Z", (string)reader["value"]);
                        rowCount++;
                    }
                    Assert.Equal(1, rowCount);
                }
            }
        }

        // TODO: Struct containing array or array containing struct.

        [Fact]
        public async Task QueryOnViewAsync()
        {
            using (var connection = new BigQueryConnection($"Data Source=projects/{_fixture.ProjectId}/datasets/{_fixture.DatasetId}"))
            {
                await connection.OpenAsync();

                var viewDefinition = new ViewDefinition { Query = $"SELECT player, MAX(score) AS score FROM {connection.GetTable(_fixture.HighScoreTableId)} WHERE player IS NOT NULL GROUP BY player ORDER BY 2 DESC", UseLegacySql = false };
                var view = await connection.CreateTableAsync("highscore_view", null, new CreateTableOptions {View = viewDefinition});
                Assert.NotNull(view.Resource.View);

                using (var sqlCmd = connection.CreateSqlCommand($"SELECT * FROM {view} WHERE player = 'Bob'"))
                using (var reader = await sqlCmd.ExecuteReaderAsync())
                {
                    var rowCount = 0;
                    while (await reader.ReadAsync())
                    {
                        Assert.Equal(85L, (long)reader["score"]);
                        rowCount++;
                    }
                    Assert.Equal(1, rowCount);
                }
            }
        }

        [Fact]
        public async Task BrokenQueryAsync()
        {
            using (var connection = new BigQueryConnection($"Data Source=projects/{_fixture.ProjectId}/datasets/{_fixture.DatasetId}"))
            {
                await connection.OpenAsync();
                await Assert.ThrowsAsync<GoogleApiException>(async () =>
                {
                    using (var sqlCmd = connection.CreateSqlCommand("This is a broken query"))
                    using (await sqlCmd.ExecuteReaderAsync())
                    {
                    }
                });
            }
        }

        [Fact(Skip = "Processes 2TB - costs money!")]
        public async Task ExecuteQuery_TimeoutAsync()
        {
            using (var connection = new BigQueryConnection($"Data Source=projects/{_fixture.ProjectId}"))
            {
                await connection.OpenAsync();
                await Assert.ThrowsAsync<TimeoutException>(async () =>
                {
                    // SQL that Jon happens to know takes over 10 seconds to query.
                    using (var sqlCmd = connection.CreateSqlCommand(
                        "SELECT id FROM [bigquery-public-data:github_repos.contents] where content contains 'NodaTime' AND content contains '2.0.2' LIMIT 1000",
                        new QueryOptions { UseLegacySql = true, UseQueryCache = false },
                        new GetQueryResultsOptions { Timeout = TimeSpan.FromSeconds(2) }))
                    using (await sqlCmd.ExecuteReaderAsync())
                    {
                    }
                });
            }
        }

        [Fact(Skip = "Processes 2TB - costs money!")]
        public async Task ExecuteQuery_Timeout2Async()
        {
            using (var connection = new BigQueryConnection($"Data Source=projects/{_fixture.ProjectId}"))
            {
                await connection.OpenAsync();
                await Assert.ThrowsAsync<TimeoutException>(async () =>
                {
                    // SQL that Jon happens to know takes over 10 seconds to query.
                    using (var sqlCmd = connection.CreateSqlCommand(
                        "SELECT id FROM [bigquery-public-data:github_repos.contents] where content contains 'NodaTime' AND content contains '2.0.2' LIMIT 1000",
                        new QueryOptions {UseLegacySql = true, UseQueryCache = false}))
                    {
                        sqlCmd.CommandTimeout = 2;
                        using (await sqlCmd.ExecuteReaderAsync())
                        {
                        }
                    }
                });
            }
        }

        [Fact]
        public async Task MultiplePagesWithStartIndexAsync()
        {
            using (var connection = new BigQueryConnection($"Data Source=projects/{_fixture.ProjectId}"))
            {
                await connection.OpenAsync();
                var table = connection.GetTable(PublicDatasetsProject, PublicDatasetsDataset, ShakespeareTable);

                var sql = $"SELECT corpus as title, COUNT(word) as unique_words FROM {table} GROUP BY title ORDER BY unique_words DESC LIMIT 20";
                using (var sqlCmd = connection.CreateSqlCommand(sql,
                    resultsOptions: new GetQueryResultsOptions { PageSize = 5, StartIndex = 7 }))
                using (var reader = await sqlCmd.ExecuteReaderAsync())
                {
                    var rowCount = 0;
                    while (await reader.ReadAsync())
                    {
                        rowCount++;
                    }
                    Assert.Equal(13, rowCount);
                }
            }
        }


        [Fact]
        public async Task DryRun_GetResultsAsync()
        {
            using (var connection = new BigQueryConnection($"Data Source=projects/{_fixture.ProjectId}"))
            {
                await connection.OpenAsync();
                var table = connection.GetTable(PublicDatasetsProject, PublicDatasetsDataset, ShakespeareTable);

                var sql = $"SELECT corpus as title, COUNT(word) as unique_words FROM {table} GROUP BY title ORDER BY unique_words DESC LIMIT 10";
                await Assert.ThrowsAsync<InvalidOperationException>(async () =>
                {
                    using (var sqlCmd = connection.CreateSqlCommand(sql, new QueryOptions {DryRun = true}))
                    using (var reader = await sqlCmd.ExecuteReaderAsync())
                    {
                        var rowCount = 0;
                        while (await reader.ReadAsync())
                        {
                            rowCount++;
                        }
                        Assert.Equal(13, rowCount);
                    }
                });
            }
        }
    }
}
