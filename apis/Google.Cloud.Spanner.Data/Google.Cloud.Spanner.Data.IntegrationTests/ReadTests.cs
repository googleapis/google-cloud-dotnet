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

using Google.Apis.Auth.OAuth2;
using Google.Cloud.Spanner.Data.CommonTesting;
using Google.Cloud.Spanner.V1;
using Grpc.Auth;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [Collection(nameof(ReadTableFixture))]
    [CommonTestDiagnostics]
    public class ReadTests
    {
        private readonly ReadTableFixture _fixture;

        public ReadTests(ReadTableFixture fixture) =>
            _fixture = fixture;

        /// <summary>
        /// This class ensures that the credential in TestDeadlineExceeded is seen as a new instance.
        /// </summary>
        private class CredentialWrapper : ITokenAccess
        {
            private readonly ITokenAccess _original;

            public CredentialWrapper(ITokenAccess original) => _original = original;

            /// <inheritdoc />
            public Task<string> GetAccessTokenForRequestAsync(
                string authUri = null,
                CancellationToken cancellationToken = new CancellationToken()) => _original
                .GetAccessTokenForRequestAsync(authUri, cancellationToken);
        }

        private async Task<T> ExecuteAsync<T>(string sql)
        {
            using (var connection = _fixture.GetConnection())
            {
                var cmd = connection.CreateSelectCommand(sql);
                var result = await cmd.ExecuteScalarAsync<T>();
                return result;
            }
        }

        [Fact]
        public async Task BadColumnName()
        {
            int rowsRead = -1;
            var e = await Assert.ThrowsAsync<SpannerException>(
                async () =>
                {
                    using (var connection = _fixture.GetConnection())
                    {
                        var cmd = connection.CreateSelectCommand($"SELECT badjuju FROM {_fixture.TableName}");
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            rowsRead = 0;
                            while (await reader.ReadAsync())
                            {
                                rowsRead++;
                            }
                        }
                    }
                }).ConfigureAwait(false);

            Assert.Equal(ErrorCode.InvalidArgument, e.ErrorCode);
            Assert.False(e.IsTransientSpannerFault());
            Assert.True(rowsRead < 1);
        }

        [Fact]
        public async Task BadDbName()
        {
            string connectionString = new SpannerConnectionStringBuilder(_fixture.ConnectionString)
                .WithDatabase("badjuju")
                .ConnectionString;
            int rowsRead = -1;

            var e = await Assert.ThrowsAsync<SpannerException>(
                async () =>
                {
                    using (var connection = new SpannerConnection(connectionString))
                    {
                        var cmd = connection.CreateSelectCommand(
                            $"SELECT * FROM {_fixture.TableName} WHERE Key = 'k1'");
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            rowsRead = 0;
                            while (await reader.ReadAsync())
                            {
                                rowsRead++;
                            }
                        }
                    }
                }).ConfigureAwait(false);

            Assert.Equal(ErrorCode.NotFound, e.ErrorCode);
            Assert.False(e.IsTransientSpannerFault());
            Assert.Equal(-1, rowsRead);
        }

        [Fact]
        public async Task BadTableName()
        {
            int rowsRead = -1;

            var e = await Assert.ThrowsAsync<SpannerException>(
                async () =>
                {
                    using (var connection = _fixture.GetConnection())
                    {
                        var cmd = connection.CreateSelectCommand("SELECT * FROM badjuju WHERE Key = 'k99'");
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            rowsRead = 0;
                            while (await reader.ReadAsync())
                            {
                                rowsRead++;
                            }
                        }
                    }
                }).ConfigureAwait(false);

            Assert.Equal(ErrorCode.InvalidArgument, e.ErrorCode);
            Assert.False(e.IsTransientSpannerFault());
            Assert.Equal(0, rowsRead);
        }

        [Fact]
        public async Task CancelRead()
        {
            var e = await Assert.ThrowsAsync<OperationCanceledException>(
                async () =>
                {
                    using (var connection = _fixture.GetConnection())
                    {
                        var cmd = connection.CreateSelectCommand($"SELECT * FROM {_fixture.TableName}");

                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            var cancellationTokenSource =
                                new CancellationTokenSource();
                            var task = reader.ReadAsync(cancellationTokenSource.Token);
                            cancellationTokenSource.Cancel();
                            await task;
                        }
                    }
                }).ConfigureAwait(false);

            Assert.False(e.IsTransientSpannerFault());
        }

        [Fact]
        public async Task EmptyStructArray()
        {
            var sqlQuery = "SELECT ARRAY(SELECT AS STRUCT * FROM (SELECT 'a', 1) WHERE 0 = 1)";
            var result = await ExecuteAsync<IList>(sqlQuery);
            Assert.Equal(0, result.Count);
        }

        [Fact]
        public async Task NaN()
        {
            double result = await ExecuteAsync<double>("SELECT IEEE_DIVIDE(0, 0)");
            Assert.True(double.IsNaN(result));
        }

        [Fact]
        public async Task NaNArray()
        {
            var result =
                await ExecuteAsync<double[]>(
                    "SELECT [IEEE_DIVIDE(1, 0), IEEE_DIVIDE(-1, 0), IEEE_DIVIDE(0, 0)]");
            Assert.Equal(3, result.Length);
            Assert.True(double.IsPositiveInfinity(result[0]));
            Assert.True(double.IsNegativeInfinity(result[1]));
            Assert.True(double.IsNaN(result[2]));
        }

        [Fact]
        public async Task NegativeInf()
        {
            double result = await ExecuteAsync<double>("SELECT IEEE_DIVIDE(-1, 0)");
            Assert.True(double.IsNegativeInfinity(result));
        }

        [Fact]
        public async Task PointRead()
        {
            int rowsRead = -1;

            using (var connection = _fixture.GetConnection())
            {
                var cmd = connection.CreateSelectCommand(
                    $"SELECT * FROM {_fixture.TableName} WHERE Key = 'k1'");
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    rowsRead = 0;
                    while (await reader.ReadAsync())
                    {
                        Assert.Equal("k1", reader.GetString(0));
                        Assert.Equal("v1", reader.GetString(1));
                        rowsRead++;
                    }
                }
            }
            Assert.Equal(1, rowsRead);
        }

        [Fact]
        public async Task ReadAllowsNewApis()
        {
            int rowsRead = -1;

            using (var connection = _fixture.GetConnection())
            {
                var cmd = connection.CreateSelectCommand(
                    $"SELECT * FROM {_fixture.TableName} WHERE Key = 'k1'");
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    rowsRead = 0;
                    while (await reader.ReadAsync())
                    {
                        Assert.Equal("k1", reader.GetFieldValue<string>("Key"));
                        Assert.Equal("v1", reader.GetFieldValue<string>("StringValue"));
                        rowsRead++;
                    }
                }
            }
            Assert.Equal(1, rowsRead);
        }

        [Fact]
        public async Task PointReadEmpty()
        {
            int rowsRead = -1;

            using (var connection = _fixture.GetConnection())
            {
                var cmd = connection.CreateSelectCommand(
                    $"SELECT * FROM {_fixture.TableName} WHERE Key = 'k99'");
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    rowsRead = 0;
                    while (await reader.ReadAsync())
                    {
                        rowsRead++;
                    }
                }
            }
            Assert.Equal(0, rowsRead);
        }

        [Fact]
        public async Task PositiveInf()
        {
            double result = await ExecuteAsync<double>("SELECT IEEE_DIVIDE(1, 0)");
            Assert.True(double.IsPositiveInfinity(result));
        }

        [Fact]
        public async Task QueryTypo()
        {
            int rowsRead = -1;
            var e = await Assert.ThrowsAsync<SpannerException>(
                async () =>
                {
                    using (var connection = _fixture.GetConnection())
                    {
                        var cmd = connection.CreateSelectCommand(
                            $"SLECT * FROM {_fixture.TableName}");
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            rowsRead = 0;
                            while (await reader.ReadAsync())
                            {
                                rowsRead++;
                            }
                        }
                    }
                }).ConfigureAwait(false);

            Assert.Equal(ErrorCode.InvalidArgument, e.ErrorCode);
            Assert.False(e.IsTransientSpannerFault());
            Assert.True(rowsRead < 1);
        }

        [Fact]
        public async Task ReadEmpty()
        {
            int rowsRead = -1;

            using (var connection = _fixture.GetConnection())
            {
                // All our keys start with "k" so there shouldn't be anything starting with "l"
                var cmd = connection.CreateSelectCommand(
                    $"SELECT * FROM {_fixture.TableName} WHERE Key >= 'l'");
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    rowsRead = 0;
                    while (await reader.ReadAsync())
                    {
                        rowsRead++;
                    }
                }
            }
            Assert.Equal(0, rowsRead);
        }

        [Fact]
        public async Task SelectOne()
        {
            long result = await ExecuteAsync<long>("SELECT 1");
            Assert.Equal(1, result);
        }

        [Fact]
        public async Task StructArray_AsDictionaryArray()
        {
            string sqlQuery = "SELECT ARRAY(SELECT AS STRUCT C1, C2 "
                + "FROM (SELECT 'a' AS C1, 1 AS C2 UNION ALL SELECT 'b' AS C1, 2 AS C2) "
                + "ORDER BY C1 ASC)";
            var result = await ExecuteAsync<List<Dictionary<string, object>>>(sqlQuery);
            Assert.Equal(2, result.Count);

            Assert.Equal("a", result[0]["C1"]);
            Assert.Equal(1L , result[0]["C2"]);

            Assert.Equal("b", result[1]["C1"]);
            Assert.Equal(2L, result[1]["C2"]);
        }

        [Fact]
        public async Task StructArray_AsSpannerStructArray()
        {
            string sqlQuery = "SELECT ARRAY(SELECT AS STRUCT C1, C2 "
                + "FROM (SELECT 'a' AS C1, 1 AS C2 UNION ALL SELECT 'b' AS C1, 2 AS C2) "
                + "ORDER BY C1 ASC)";
            var result = await ExecuteAsync<List<SpannerStruct>>(sqlQuery);
            Assert.Equal(2, result.Count);

            var struct1 = result[0];
            AssertStructField("C1", SpannerDbType.String, "a", struct1[0]);
            AssertStructField("C2", SpannerDbType.Int64, 1L, struct1[1]);

            var struct2 = result[1];
            AssertStructField("C1", SpannerDbType.String, "b", struct2[0]);
            AssertStructField("C2", SpannerDbType.Int64, 2L, struct2[1]);
        }

        [Fact]
        public async Task StructArray_DuplicateAndEmptyFieldNames()
        {
            var result = await ExecuteAsync<SpannerStruct[]>("SELECT ARRAY(SELECT STRUCT(1, 2 as f, 3 as f))");
            Assert.Equal(1, result.Length);
            var structValue = result[0];
            Assert.Equal(3, structValue.Count);

            AssertStructField("", SpannerDbType.Int64, 1L, structValue[0]);
            AssertStructField("f", SpannerDbType.Int64, 2L, structValue[1]);
            AssertStructField("f", SpannerDbType.Int64, 3L, structValue[2]);
        }

        private static void AssertStructField(string expectedName, SpannerDbType expectedType, object expectedValue, SpannerStruct.Field actualField)
        {
            Assert.Equal(expectedName, actualField.Name);
            Assert.Equal(expectedType, actualField.Type);
            Assert.Equal(expectedValue, actualField.Value);
        }

        [Fact]
        public async Task ReadNullValue_Legacy()
        {
            using (var connection = new SpannerConnection($"{_fixture.ConnectionString};UseClrDefaultForNull=true"))
            {
                var cmd = connection.CreateSelectCommand(
                    $"SELECT Key, StringValue FROM {_fixture.TableName} WHERE Key = 'kNull'");
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    Assert.True(await reader.ReadAsync());
                    Assert.Equal("kNull", reader.GetString(0));
                    Assert.Null(reader.GetString(1));
                    Assert.Null(reader[1]);
                    Assert.Null(reader["StringValue"]);
                    Assert.True(reader.IsDBNull(1));

                    // No more rows
                    Assert.False(await reader.ReadAsync());
                }
            }
        }

        [Fact]
        public async Task ReadNullValue_DBNull()
        {
            using (var connection = new SpannerConnection(_fixture.ConnectionString))
            {
                var cmd = connection.CreateSelectCommand(
                    $"SELECT Key, StringValue FROM {_fixture.TableName} WHERE Key = 'kNull'");
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    Assert.True(await reader.ReadAsync());
                    Assert.Equal("kNull", reader.GetString(0));
                    Assert.Throws<InvalidCastException>(() => reader.GetString(1));
                    Assert.Equal(DBNull.Value, reader[1]);
                    Assert.Equal(DBNull.Value, reader["StringValue"]);
                    Assert.True(reader.IsDBNull(1));

                    // No more rows
                    Assert.False(await reader.ReadAsync());
                }
            }
        }

        [Fact]
        public async Task CommandTimeout()
        {
            long result = 0;
            var e = await Assert.ThrowsAsync<SpannerException>(
                async () =>
                {
                    using (var connection =
                        new SpannerConnection($"{_fixture.ConnectionString};{nameof(SpannerSettings.AllowImmediateTimeouts)}=true"))
                    {
                        var cmd = connection.CreateSelectCommand("SELECT 1");
                        cmd.CommandTimeout = 0;
                        result = await cmd.ExecuteScalarAsync<long>();
                    }
                }).ConfigureAwait(false);

            SpannerAssert.IsTimeout(e);
            Assert.Equal(0, result);
        }

        [Fact]
        public async Task TimeoutFromOptions()
        {
            var oldTimeout = SpannerOptions.Instance.Timeout;
            SpannerOptions.Instance.Timeout = 0;

            try
            {
                // We use a new instance of a credential to force create a new SpannerClient,
                // which will cause the new options to be respected (Timeout in this case).
                // Normally setting the timeout in SpannerOptions.Instance is only supported before creation of any client and cannot
                // be changed due to the fact we pool clients.
                var appDefaultCredentials = await GoogleCredential.GetApplicationDefaultAsync().ConfigureAwait(false);
                if (appDefaultCredentials.IsCreateScopedRequired)
                {
                    appDefaultCredentials = appDefaultCredentials.CreateScoped(SpannerClient.DefaultScopes);
                }

                long result = 0;
                var e = await Assert.ThrowsAsync<SpannerException>(
                    async () =>
                    {
                        string connectionString = $"{_fixture.ConnectionString};{nameof(SpannerSettings.AllowImmediateTimeouts)}=true";
                        var channelCredentials = new CredentialWrapper(appDefaultCredentials).ToChannelCredentials();
                        using (var connection = new SpannerConnection(connectionString, channelCredentials))
                        {
                            var cmd = connection.CreateSelectCommand("SELECT 1");
                            Assert.Equal(0, cmd.CommandTimeout);
                            result = await cmd.ExecuteScalarAsync<long>();
                        }
                    }).ConfigureAwait(false);

                SpannerAssert.IsTimeout(e);
                Assert.Equal(0, result);
            }
            finally
            {
                SpannerOptions.Instance.Timeout = oldTimeout;
            }
        }
    }
}
