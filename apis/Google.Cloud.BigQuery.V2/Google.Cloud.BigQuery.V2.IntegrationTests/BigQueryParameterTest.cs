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

using System;
using System.Linq;
using Xunit;

namespace Google.Cloud.BigQuery.V2.IntegrationTests
{
    [Collection(nameof(BigQueryFixture))]
    public class BigQueryParameterTest
    {
        private readonly BigQueryFixture _fixture;

        public BigQueryParameterTest(BigQueryFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void IntegerParameter()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var command = new BigQueryCommand("SELECT value FROM UNNEST([0, 1, 2, 3, 4]) AS value WHERE value > @value ORDER BY value")
            {
                Parameters = { { "value", BigQueryDbType.Int64, 2 } }
            };
            var results = client.ExecuteQuery(command).ReadPage(10);
            Assert.Equal(new[] { 3L, 4L }, results.Rows.Select(r => (long) r["value"]));
        }

        [Fact]
        public void IntegerArrayParameter()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var command = new BigQueryCommand("SELECT value FROM UNNEST([0, 1, 2, 3, 4]) AS value WHERE value IN UNNEST(@p) ORDER BY value")
            {
                Parameters = { { "p", BigQueryDbType.Array, new[] { 1, 3, 5 } } }
            };
            var results = client.ExecuteQuery(command).ReadPage(10);
            Assert.Equal(new[] { 1L, 3L }, results.Rows.Select(r => (long)r["value"]));
        }

        [Fact]
        public void TimestampParameter()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var table = client.GetTable(_fixture.DatasetId, _fixture.HighScoreTableId);
            var command = new BigQueryCommand($"SELECT score FROM {table} WHERE player=@player AND gameStarted > @start")
            {
                Parameters =
                {
                    { "player", BigQueryDbType.String, "Angela" },
                    { "start", BigQueryDbType.Timestamp, new DateTime(2001, 12, 31, 23, 59, 59, DateTimeKind.Utc) },
                }
            };
            // Find the value when we've provided a timestamp smaller than the actual value
            var results = client.ExecuteQuery(command).ReadPage(10);
            Assert.Equal(1, results.Rows.Count);

            // We shouldn't find it now. (Angela's game started at 2002-01-01T00:00:00Z)
            command.Parameters[1].Value = new DateTime(2002, 1, 1, 0, 0, 1, DateTimeKind.Utc);
            results = client.ExecuteQuery(command).ReadPage(10);
            Assert.Equal(0, results.Rows.Count);
        }

        [Fact]
        public void NullParameter()
        {
            // Assumption: no other test inserts a row with a null player name.
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var table = client.GetTable(_fixture.DatasetId, _fixture.HighScoreTableId);
            var parameter = new BigQueryParameter("player", BigQueryDbType.String, "Angela");
            var command = new BigQueryCommand($"SELECT score FROM {table} WHERE player=@player") { Parameters = { parameter } };
            var resultSet = client.ExecuteQuery(command).ReadPage(5);
            Assert.Equal(1, resultSet.Rows.Count);
            Assert.Equal(95, (long)resultSet.Rows[0]["score"]);

            // SQL rules: nothing equals null
            parameter.Value = null;
            resultSet = client.ExecuteQuery(command).ReadPage(5);
            Assert.Equal(0, resultSet.Rows.Count);

            // But we should be able to find the null value this way.
            command.Sql = $"SELECT score FROM {table} WHERE player=@player OR (player IS NULL AND @player IS NULL)";
            resultSet = client.ExecuteQuery(command).ReadPage(5);
            Assert.Equal(1, resultSet.Rows.Count);
            Assert.Equal(1, (long)resultSet.Rows[0]["score"]);
        }

        [Fact]
        public void BytesParameter()
        {
            var command = new BigQueryCommand($"SELECT BYTE_LENGTH(@p) AS length")
            {
                Parameters = { { "p", BigQueryDbType.Bytes, new byte[] { 1, 3 } } }
            };
            var row = GetSingleRow(command);
            Assert.Equal(2, (long)row["length"]);
        }

        private BigQueryRow GetSingleRow(BigQueryCommand command)
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var results = client.ExecuteQuery(command).ReadPage(10);
            Assert.Equal(1, results.Rows.Count);
            return results.Rows[0];
        }
    }
}
