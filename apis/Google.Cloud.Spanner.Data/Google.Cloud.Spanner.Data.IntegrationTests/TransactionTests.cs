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

#region

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

#endregion

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [PerformanceLog]
    [Collection(nameof(TestDatabaseFixture))]
    public class TransactionTests
    {
        // ReSharper disable once UnusedParameter.Local
        public TransactionTests(TestDatabaseFixture testFixture, ITestOutputHelper outputHelper)
        {
            _testFixture = testFixture;
#if LoggingOn
            SpannerConnection.ConnectionPoolOptions.LogLevel = LogLevel.Debug;
            SpannerConnection.ConnectionPoolOptions.LogPerformanceTraces = true;
            SpannerConnection.ConnectionPoolOptions.PerformanceTraceLogInterval = 1000;
#endif
            TestLogger.TestOutputHelper = outputHelper;
        }

        private readonly TestDatabaseFixture _testFixture;
        private string _key;
        private readonly List<HistoryEntry> _history = new List<HistoryEntry>();

        private class HistoryEntry
        {
            public string Value { get; set; }
            public DateTime Timestamp { get; set; }
        }

        private async Task WriteSampleRowsAsync()
        {
            await _testFixture.EnsureTestDatabaseAsync();
            if (string.IsNullOrEmpty(_key))
            {
                _key = Guid.NewGuid().ToString();
                using (var connection = await _testFixture.GetTestDatabaseConnectionAsync())
                {
                    SpannerCommand insupdate;
                    // 1st update
                    await connection.OpenAsync();
                    using (var tx = await connection.BeginTransactionAsync())
                    {
                        insupdate = connection.CreateInsertOrUpdateCommand(
                            "TX",
                            new SpannerParameterCollection
                            {
                                {"K", _key, SpannerDbType.String},
                                {"StringValue", Guid.NewGuid().ToString(), SpannerDbType.String}
                            });
                        insupdate.Transaction = tx;
                        await insupdate.ExecuteNonQueryAsync();
                        var timestamp = await tx.CommitAsync();
                        _history.Add(
                            new HistoryEntry
                            {
                                Value = insupdate.Parameters[1].Value.ToString(),
                                Timestamp = timestamp.GetValueOrDefault()
                            });
                    }

                    await Task.Delay(250);

                    // 2nd update
                    using (var tx = await connection.BeginTransactionAsync())
                    {
                        insupdate.Transaction = tx;
                        insupdate.CommandText = "UPDATE TX";
                        insupdate.Parameters[1].Value = Guid.NewGuid().ToString();
                        await insupdate.ExecuteNonQueryAsync();
                        var timestamp = await tx.CommitAsync();
                        _history.Add(
                            new HistoryEntry
                            {
                                Value = insupdate.Parameters[1].Value.ToString(),
                                Timestamp = timestamp.GetValueOrDefault()
                            });
                    }

                    await Task.Delay(250);

                    // 3rd update
                    using (var tx = await connection.BeginTransactionAsync())
                    {
                        insupdate.Transaction = tx;
                        insupdate.Parameters[1].Value = Guid.NewGuid().ToString();
                        await insupdate.ExecuteNonQueryAsync();
                        var timestamp = await tx.CommitAsync();
                        _history.Add(
                            new HistoryEntry
                            {
                                Value = insupdate.Parameters[1].Value.ToString(),
                                Timestamp = timestamp.GetValueOrDefault()
                            });
                    }
                }
            }
        }

        private async Task IncrementByOneAsync(SpannerConnection connection)
        {
            SpannerException spannerException;
            do
            {
                spannerException = null;
                try
                {
                    //We'll do manually created transactions here so the tests run on .net core
                    using (var transaction = await connection.BeginTransactionAsync())
                    {
                        long current;
                        using (var cmd =
                            connection.CreateSelectCommand(
                                "SELECT Int64Value FROM TX WHERE K=@k",
                                new SpannerParameterCollection {{"k", _key, SpannerDbType.String}}))
                        {
                            cmd.Transaction = transaction;
                            current = await cmd.ExecuteScalarAsync<long>().ConfigureAwait(false);
                        }

                        using (var cmd = connection.CreateUpdateCommand(
                            "TX",
                            new SpannerParameterCollection
                            {
                                {"k", _key, SpannerDbType.String},
                                {"Int64Value", current + 1, SpannerDbType.Int64}
                            }))
                        {
                            cmd.Transaction = transaction;
                            await cmd.ExecuteNonQueryAsync().ConfigureAwait(false);
                            await transaction.CommitAsync().ConfigureAwait(false);
                        }
                    }
                }
                catch (SpannerException ex)
                {
                    spannerException = ex;
                }
            } while (spannerException?.IsRetryable ?? false);
        }

        private async Task<SpannerConnection> CreateAndOpen()
        {
            var connection = new SpannerConnection(_testFixture.ConnectionString);
            await connection.OpenAsync();
            return connection;
        }

        [Fact]
        public async Task AbortedThrownCorrectly()
        {
            await WriteSampleRowsAsync();

            // connection 1 starts a transaction and reads
            // connection 2 starts a transaction and reads the same row
            // connection 1 writes and commits
            // connection 2 reads again -- abort should be thrown.
            var connection1 = new SpannerConnection(_testFixture.ConnectionString);
            var connection2 = new SpannerConnection(_testFixture.ConnectionString);

            await Task.WhenAll(connection1.OpenAsync(), connection2.OpenAsync());
            var tx1 = await connection1.BeginTransactionAsync();

            // TX1 READ
            using (var cmd = connection1.CreateSelectCommand(
                "SELECT * FROM TX WHERE K=@k",
                new SpannerParameterCollection {{"k", _key, SpannerDbType.String}}))
            {
                cmd.Transaction = tx1;
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    Assert.True(await reader.ReadAsync());
                }
            }

            // TX2 START
            var tx2 = await connection2.BeginTransactionAsync();

            // TX2 READ
            using (var cmd = connection2.CreateSelectCommand(
                "SELECT * FROM TX WHERE K=@k",
                new SpannerParameterCollection {{"k", _key, SpannerDbType.String}}))
            {
                cmd.Transaction = tx2;
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    Assert.True(await reader.ReadAsync());
                }
            }

            // TX1 WRITE/COMMIT
            using (var cmd = connection1.CreateUpdateCommand(
                "TX",
                new SpannerParameterCollection
                {
                    {"k", _key, SpannerDbType.String},
                    {"Int64Value", 0, SpannerDbType.Int64}
                }))
            {
                cmd.Transaction = tx1;
                await cmd.ExecuteNonQueryAsync().ConfigureAwait(false);
                await tx1.CommitAsync().ConfigureAwait(false);
                tx1.Dispose();
            }
            connection1.Dispose();

            // TX2 READ AGAIN/THROWS
            SpannerException thrownException = null;
            try
            {
                using (var cmd = connection2.CreateSelectCommand(
                    "SELECT * FROM TX WHERE K=@k",
                    new SpannerParameterCollection {{"k", _key, SpannerDbType.String}}))
                {
                    cmd.Transaction = tx2;
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        Assert.True(await reader.ReadAsync());
                    }
                }
            }
            catch (SpannerException ex)
            {
                thrownException = ex;
            }
            finally
            {
                tx2.Dispose();
                connection2.Dispose();
            }

            Assert.True(thrownException?.IsRetryable ?? false);
        }

        [Fact]
        public async Task MultiWrite()
        {
            await WriteSampleRowsAsync();
            //To ensure good concurrency (ie that the transactions are not serial)
            //we'll preopen 5 transactions to ensure they have sessions and then start the increment
            //process
            const int concurrentThreads = 5;
            var connections = new SpannerConnection[concurrentThreads];
            for (var i = 0; i < concurrentThreads; i++)
            {
                connections[i] = await CreateAndOpen();
            }

            var tasks = new Task[concurrentThreads];
            for (var i = 0; i < concurrentThreads; i++)
            {
                tasks[i] = IncrementByOneAsync(connections[i]);
            }
            await Task.WhenAll(tasks).ConfigureAwait(false);

            //now ensure we have the correct value
            using (var cmd =
                connections[0].CreateSelectCommand(
                    "SELECT Int64Value FROM TX WHERE K=@k",
                    new SpannerParameterCollection {{"k", _key, SpannerDbType.String}}))
            {
                Assert.Equal(5, await cmd.ExecuteScalarAsync<long>().ConfigureAwait(false));
            }

            for (var i = 0; i < concurrentThreads; i++)
            {
                connections[i].Dispose();
            }
        }

        [Fact]
        public async Task ReadExact()
        {
            await WriteSampleRowsAsync();
            using (var connection = await _testFixture.GetTestDatabaseConnectionAsync())
            {
                await connection.OpenAsync();
                var targetReadTimestamp = _history[0].Timestamp.AddMinutes(-1);
                using (var tx =
                    await connection.BeginReadOnlyTransactionAsync(
                        TimestampBound.OfReadTimestamp(targetReadTimestamp)))
                {
                    Assert.Equal(TransactionMode.ReadOnly, tx.Mode);
                    Assert.Equal(targetReadTimestamp, tx.TimestampBound.Timestamp);

                    var cmd = connection.CreateSelectCommand(
                        "SELECT * FROM TX WHERE K=@k",
                        new SpannerParameterCollection {{"k", _key, SpannerDbType.String}});
                    cmd.Transaction = tx;
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        Assert.False(
                            await reader.ReadAsync(),
                            "no data should be here from yesterday!");
                    }
                }
            }
        }

        [Fact]
        public async Task ReadExactSingle()
        {
            await WriteSampleRowsAsync();
            await Task.Delay(6);
            using (var connection = await _testFixture.GetTestDatabaseConnectionAsync())
            {
                await connection.OpenAsync();
                var cmd = connection.CreateSelectCommand(
                    "SELECT * FROM TX WHERE K=@k",
                    new SpannerParameterCollection {{"k", _key, SpannerDbType.String}});
                using (var reader = await cmd.ExecuteReaderAsync(TimestampBound.OfReadTimestamp(_history[0].Timestamp)))
                {
                    if (await reader.ReadAsync())
                    {
                        Assert.Equal(_history[0].Value, reader.GetFieldValue<string>(reader.GetOrdinal("StringValue")));
                    }
                }
            }
        }

        [Fact]
        public async Task ReadMin()
        {
            ArgumentException caughtException = null;

            await WriteSampleRowsAsync();
            using (var connection = await _testFixture.GetTestDatabaseConnectionAsync())
            {
                await connection.OpenAsync();
                try
                {
                    await connection.BeginReadOnlyTransactionAsync(
                        TimestampBound.OfMinReadTimestamp(_history[2].Timestamp));
                }
                catch (ArgumentException ex)
                {
                    caughtException = ex;
                }

                var cmd = connection.CreateSelectCommand(
                    "SELECT * FROM TX WHERE K=@k",
                    new SpannerParameterCollection {{"k", _key, SpannerDbType.String}});
                using (var reader =
                    await cmd.ExecuteReaderAsync(
                        TimestampBound.OfMinReadTimestamp(_history[2].Timestamp)))
                {
                    if (await reader.ReadAsync())
                    {
                        Assert.Equal(_history[2].Value, reader.GetFieldValue<string>(reader.GetOrdinal("StringValue")));
                    }
                }
            }
            Assert.NotNull(caughtException);
        }

        [Fact]
        public async Task ReadStaleExact()
        {
            await WriteSampleRowsAsync();
            using (var connection = await _testFixture.GetTestDatabaseConnectionAsync())
            {
                await connection.OpenAsync();
                using (var tx =
                    await connection.BeginReadOnlyTransactionAsync(
                        TimestampBound.OfExactStaleness(TimeSpan.FromSeconds(50))))
                {
                    Assert.Equal(TransactionMode.ReadOnly, tx.Mode);
                    Assert.Equal(TimeSpan.FromSeconds(50), tx.TimestampBound.Staleness);

                    var cmd = connection.CreateSelectCommand(
                        "SELECT * FROM TX WHERE K=@k",
                        new SpannerParameterCollection {{"k", _key, SpannerDbType.String}});
                    cmd.Transaction = tx;
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        Assert.False(await reader.ReadAsync(), "We should have read no rows at this time!");
                    }
                }
            }
        }

        [Fact]
        public async Task ReadStaleExactSingle()
        {
            await WriteSampleRowsAsync();
            using (var connection = await _testFixture.GetTestDatabaseConnectionAsync())
            {
                await connection.OpenAsync();
                var cmd = connection.CreateSelectCommand(
                    "SELECT * FROM TX WHERE K=@k",
                    new SpannerParameterCollection {{"k", _key, SpannerDbType.String}});
                using (var reader =
                    await cmd.ExecuteReaderAsync(TimestampBound.OfExactStaleness(TimeSpan.FromSeconds(50))))
                {
                    Assert.False(await reader.ReadAsync(), "We should have read no rows at this time!");
                }
            }
        }

        [Fact]
        public async Task ReadStaleMax()
        {
            ArgumentException caughtException = null;

            await WriteSampleRowsAsync();
            await Task.Delay(6);
            using (var connection = await _testFixture.GetTestDatabaseConnectionAsync())
            {
                await connection.OpenAsync();
                try
                {
                    await connection.BeginReadOnlyTransactionAsync(
                        TimestampBound.OfMaxStaleness(TimeSpan.FromSeconds(50)));
                }
                catch (ArgumentException ex)
                {
                    caughtException = ex;
                }

                var cmd = connection.CreateSelectCommand(
                    "SELECT * FROM TX WHERE K=@k",
                    new SpannerParameterCollection {{"k", _key, SpannerDbType.String}});
                using (var reader =
                    await cmd.ExecuteReaderAsync(
                        TimestampBound.OfMaxStaleness(TimeSpan.FromMilliseconds(5))))
                {
                    if (await reader.ReadAsync())
                    {
                        Assert.Equal(_history[2].Value, reader.GetFieldValue<string>(reader.GetOrdinal("StringValue")));
                    }
                }
            }
            Assert.NotNull(caughtException);
        }

        [Fact]
        public async Task ReadStrong()
        {
            await WriteSampleRowsAsync();
            using (var connection = await _testFixture.GetTestDatabaseConnectionAsync())
            {
                await connection.OpenAsync();
                using (var tx =
                    await connection.BeginReadOnlyTransactionAsync(TimestampBound.Strong))
                {
                    var cmd = connection.CreateSelectCommand(
                        "SELECT * FROM TX WHERE K=@k",
                        new SpannerParameterCollection {{"k", _key, SpannerDbType.String}});
                    cmd.Transaction = tx;
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            Assert.Equal(
                                _history[2].Value, reader.GetFieldValue<string>(reader.GetOrdinal("StringValue")));
                        }
                    }
                }
            }
        }

        [Fact]
        public async Task ReadStrongSingle()
        {
            await WriteSampleRowsAsync();
            using (var connection = await _testFixture.GetTestDatabaseConnectionAsync())
            {
                await connection.OpenAsync();
                var cmd = connection.CreateSelectCommand(
                    "SELECT * FROM TX WHERE K=@k",
                    new SpannerParameterCollection {{"k", _key, SpannerDbType.String}});
                using (var reader = await cmd.ExecuteReaderAsync(TimestampBound.Strong))
                {
                    if (await reader.ReadAsync())
                    {
                        Assert.Equal(_history[2].Value, reader.GetFieldValue<string>(reader.GetOrdinal("StringValue")));
                    }
                }
            }
        }
    }
}
