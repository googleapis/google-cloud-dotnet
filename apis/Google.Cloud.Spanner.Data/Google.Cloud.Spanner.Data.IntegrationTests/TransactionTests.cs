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

using Google.Cloud.ClientTesting;
using Google.Cloud.Spanner.Data.CommonTesting;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
#if !NETCOREAPP1_0
using System.Transactions;
#endif
using Xunit;
using Xunit.Abstractions;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [PerformanceLog]
    [Collection(nameof(TransactionTableFixture))]
    public class TransactionTests
    {
        private readonly TransactionTableFixture _fixture;

        /// <summary>
        /// Key just for this test.
        /// </summary>
        private readonly string _key;
        private readonly HistoryEntry _oldestEntry;
        private readonly HistoryEntry _newestEntry;

        public TransactionTests(TransactionTableFixture fixture, ITestOutputHelper outputHelper)
        {
            _fixture = fixture;
#if LoggingOn
            SpannerConnection.ConnectionPoolOptions.LogLevel = LogLevel.Debug;
            SpannerConnection.ConnectionPoolOptions.LogPerformanceTraces = true;
            SpannerConnection.ConnectionPoolOptions.PerformanceTraceLogInterval = 1000;
#endif
            TestLogger.TestOutputHelper = outputHelper;
            _key = Guid.NewGuid().ToString();
            (_oldestEntry, _newestEntry) = PopulateTableForTest(fixture, _key);
        }

        private static (HistoryEntry oldest, HistoryEntry newest) PopulateTableForTest(TransactionTableFixture fixture, string key)
        {
            HistoryEntry oldest = default, newest = default;
            using (var connection = fixture.GetConnection())
            {
                connection.Open();

                SpannerCommand command = connection.CreateInsertOrUpdateCommand(fixture.TableName);
                command.Parameters.Add("K", SpannerDbType.String, key);
                var valueParameter = command.Parameters.Add("StringValue", SpannerDbType.String);

                // 1st update with TestKey
                RetryHelpers.RetryOnce(() =>
                {
                    using (var tx = connection.BeginTransaction())
                    {
                        command.Transaction = tx;
                        valueParameter.Value = Guid.NewGuid().ToString();
                        command.ExecuteNonQuery();
                        tx.Commit(out var timestamp);
                        oldest = new HistoryEntry((string)valueParameter.Value, timestamp.Value);
                    }
                });

                Thread.Sleep(250);

                // 2nd update
                RetryHelpers.RetryOnce(() =>
                {
                    using (var tx = connection.BeginTransaction())
                    {
                        command.Transaction = tx;
                        command.CommandText = $"UPDATE {fixture.TableName}";
                        valueParameter.Value = Guid.NewGuid().ToString();
                        command.ExecuteNonQuery();
                        tx.Commit();
                    }
                });

                Thread.Sleep(250);

                // 3rd update
                RetryHelpers.RetryOnce(() =>
                {
                    using (var tx = connection.BeginTransaction())
                    {
                        command.Transaction = tx;
                        valueParameter.Value = Guid.NewGuid().ToString();
                        command.ExecuteNonQuery();
                        tx.Commit(out var timestamp);
                        newest = new HistoryEntry((string)valueParameter.Value, timestamp.Value);
                    }
                });

                // Wait for time to pass after this
                Thread.Sleep(250);
            }
            return (oldest, newest);
        }

        private async Task IncrementByOneAsync(SpannerConnection connection, bool orphanTransaction = false)
        {
            SpannerException spannerException;
            do
            {
                spannerException = null;
                try
                {
                    // We'll do manually created transactions here so the tests run on .net core
                    using (var transaction = await connection.BeginTransactionAsync())
                    {
                        long current;
                        using (var cmd =
                            connection.CreateSelectCommand(
                                $"SELECT Int64Value FROM {_fixture.TableName} WHERE K=@k",
                                new SpannerParameterCollection { { "k", SpannerDbType.String, _key } }))
                        {
                            cmd.Transaction = transaction;
                            var fetched = await cmd.ExecuteScalarAsync().ConfigureAwait(false);
                            current = fetched is DBNull ? 0L : (long) fetched;
                        }

                        using (var cmd = connection.CreateUpdateCommand(_fixture.TableName,
                            new SpannerParameterCollection
                            {
                                {"k", SpannerDbType.String, _key},
                                {"Int64Value", SpannerDbType.Int64, current + 1}
                            }))
                        {
                            cmd.Transaction = transaction;
                            await cmd.ExecuteNonQueryAsync().ConfigureAwait(false);
                            if (!orphanTransaction)
                            {
                                await transaction.CommitAsync().ConfigureAwait(false);
                            }
                        }
                    }
                }
                catch (SpannerException ex)
                {
                    spannerException = ex;
                }
            } while (spannerException?.IsRetryable ?? false);
        }

        private SpannerCommand CreateSelectAllCommandForKey(SpannerConnection connection) =>
            connection.CreateSelectCommand(
                $"SELECT * FROM {_fixture.TableName} WHERE K=@k",
                new SpannerParameterCollection { { "k", SpannerDbType.String, _key } });

        [Fact]
        public async Task DisposedTransactionDoesntLeak()
        {
            // This test ensures that a transaction that had neither commit nor rollback called does
            // not leak its transaction state to a subsequent transaction.
            // The way this works currently is that every session added to the pool gets its state cleared.
            // The reserved session in SpannerConnection can only be used for readonly transactions and is
            // therefore immune to this bug.  However if that every changes, this test will catch it.
            using (var connection = _fixture.GetConnection())
            {
                connection.Open();
                // The following line increments by one, but never commits the transaction, allowing it
                // to get disposed (which releases the session).
                await IncrementByOneAsync(connection, true);

                await RetryHelpers.RetryOnceAsync(async () =>
                {
                    using (var tx = await connection.BeginTransactionAsync())
                    {
                        // Because Cloud Spanner does not have "read your writes"
                        // to test any leaks, we must commit the transaction and then read it.
                        await tx.CommitAsync();
                    }
                });

                // The value should not be present in the table.
                using (var cmd =
                        connection.CreateSelectCommand(
                            $"SELECT Int64Value FROM {_fixture.TableName} WHERE K=@k",
                            new SpannerParameterCollection { { "k", SpannerDbType.String, _key } }))
                {
                    Assert.Equal(DBNull.Value, await cmd.ExecuteScalarAsync().ConfigureAwait(false));
                }
            }
        }

        [Fact]
        public async Task AbortedThrownCorrectly()
        {
            // connection 1 starts a transaction and reads
            // connection 2 starts a transaction and reads the same row
            // connection 1 writes and commits
            // connection 2 reads again -- abort should be thrown.
            var connection1 = new SpannerConnection(_fixture.ConnectionString);
            var connection2 = new SpannerConnection(_fixture.ConnectionString);

            await Task.WhenAll(connection1.OpenAsync(), connection2.OpenAsync());
            var tx1 = await connection1.BeginTransactionAsync();

            // TX1 READ
            using (var cmd = CreateSelectAllCommandForKey(connection1))
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
            using (var cmd = CreateSelectAllCommandForKey(connection2))
            {
                cmd.Transaction = tx2;
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    Assert.True(await reader.ReadAsync());
                }
            }

            // TX1 WRITE/COMMIT
            using (var cmd = connection1.CreateUpdateCommand(
                _fixture.TableName,
                new SpannerParameterCollection
                {
                    {"k", SpannerDbType.String, _key},
                    {"Int64Value", SpannerDbType.Int64, 0}
                }))
            {
                cmd.Transaction = tx1;
                await cmd.ExecuteNonQueryAsync().ConfigureAwait(false);
                await tx1.CommitAsync().ConfigureAwait(false);
                tx1.Dispose();
            }
            connection1.Dispose();

            // TX2 READ AGAIN/THROWS
            var thrownException = await Assert.ThrowsAsync<SpannerException>(
                async () =>
                {
                    using (var cmd = CreateSelectAllCommandForKey(connection2))
                    {
                        cmd.Transaction = tx2;
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            Assert.True(await reader.ReadAsync());
                        }
                    }
                }).ConfigureAwait(false);
            tx2.Dispose();
            connection2.Dispose();
            Assert.True(thrownException?.IsRetryable ?? false);
        }

        [Fact]
        public async Task MultiWrite()
        {
            //To ensure good concurrency (ie that the transactions are not serial)
            //we'll preopen 5 transactions to ensure they have sessions and then start the increment
            //process
            const int concurrentThreads = 5;
            var connections = new SpannerConnection[concurrentThreads];
            for (var i = 0; i < concurrentThreads; i++)
            {
                connections[i] = _fixture.GetConnection();
                connections[i].Open();
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
                    $"SELECT Int64Value FROM {_fixture.TableName} WHERE K=@k",
                    new SpannerParameterCollection { { "k", SpannerDbType.String, _key } }))
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
            using (var connection = _fixture.GetConnection())
            {
                await connection.OpenAsync();
                var targetReadTimestamp = _fixture.TimestampBeforeEntries;
                using (var tx =
                    await connection.BeginReadOnlyTransactionAsync(
                        TimestampBound.OfReadTimestamp(targetReadTimestamp)))
                {
                    Assert.Equal(TransactionMode.ReadOnly, tx.Mode);
                    Assert.Equal(targetReadTimestamp, tx.TimestampBound.Timestamp);

                    var cmd = CreateSelectAllCommandForKey(connection);
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
            using (var connection = _fixture.GetConnection())
            {
                await connection.OpenAsync();
                var cmd = CreateSelectAllCommandForKey(connection);
                using (var reader = await cmd.ExecuteReaderAsync(TimestampBound.OfReadTimestamp(_oldestEntry.Timestamp)))
                {
                    if (await reader.ReadAsync())
                    {
                        Assert.Equal(_oldestEntry.Value, reader.GetFieldValue<string>(reader.GetOrdinal("StringValue")));
                    }
                }
            }
        }

        [Fact]
        public async Task ReadMin()
        {
            using (var connection = _fixture.GetConnection())
            {
                await connection.OpenAsync();
                await Assert.ThrowsAsync<ArgumentException>(
                    async () =>
                    {
                        await connection.BeginReadOnlyTransactionAsync(
                            TimestampBound.OfMinReadTimestamp(_newestEntry.Timestamp));

                    }).ConfigureAwait(false);

                var cmd = CreateSelectAllCommandForKey(connection);
                using (var reader =
                    await cmd.ExecuteReaderAsync(
                        TimestampBound.OfMinReadTimestamp(_newestEntry.Timestamp)))
                {
                    if (await reader.ReadAsync())
                    {
                        Assert.Equal(_newestEntry.Value, reader.GetFieldValue<string>(reader.GetOrdinal("StringValue")));
                    }
                }
            }
        }

        [Fact]
        public async Task ReadStaleExact()
        {
            using (var connection = _fixture.GetConnection())
            {
                await connection.OpenAsync();
                var bound = TimestampBound.OfExactStaleness(_fixture.Staleness);
                using (var tx = await connection.BeginReadOnlyTransactionAsync(bound))
                {
                    Assert.Equal(TransactionMode.ReadOnly, tx.Mode);
                    Assert.Equal(_fixture.Staleness, tx.TimestampBound.Staleness);

                    var cmd = CreateSelectAllCommandForKey(connection);
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
            using (var connection = _fixture.GetConnection())
            {
                await connection.OpenAsync();
                var cmd = CreateSelectAllCommandForKey(connection);
                var bound = TimestampBound.OfExactStaleness(_fixture.Staleness);
                using (var reader = await cmd.ExecuteReaderAsync(bound))
                {
                    Assert.False(await reader.ReadAsync(), "We should have read no rows at this time!");
                }
            }
        }

        [Fact]
        public async Task ReadStaleMax()
        {
            using (var connection = _fixture.GetConnection())
            {
                await connection.OpenAsync();
                await Assert.ThrowsAsync<ArgumentException>(
                    async () =>
                    {
                        var bound = TimestampBound.OfMaxStaleness(_fixture.Staleness);
                        await connection.BeginReadOnlyTransactionAsync(bound);
                    }).ConfigureAwait(false);

                var cmd = CreateSelectAllCommandForKey(connection);
                var recentBound = TimestampBound.OfMaxStaleness(TimeSpan.FromMilliseconds(5));
                using (var reader = await cmd.ExecuteReaderAsync(recentBound))
                {
                    if (await reader.ReadAsync())
                    {
                        Assert.Equal(_newestEntry.Value, reader.GetFieldValue<string>(reader.GetOrdinal("StringValue")));
                    }
                }
            }
        }

        [Fact]
        public async Task ReadStrong()
        {
            using (var connection = _fixture.GetConnection())
            {
                await connection.OpenAsync();
                using (var tx = await connection.BeginReadOnlyTransactionAsync(TimestampBound.Strong))
                {
                    var cmd = CreateSelectAllCommandForKey(connection);
                    cmd.Transaction = tx;
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            Assert.Equal(
                                _newestEntry.Value,
                                reader.GetFieldValue<string>(reader.GetOrdinal("StringValue")));
                        }
                    }
                }
            }
        }

#if !NETCOREAPP1_0
        private async Task UpdateValueInTransactionScope(SpannerConnection writeConnection)
        {
            var writeCommand = writeConnection.CreateUpdateCommand(
                 _fixture.TableName,
                new SpannerParameterCollection
                {
                    {"k", SpannerDbType.String, _key},
                    {"Int64Value", SpannerDbType.Int64, 0}
                });
            await writeCommand.ExecuteNonQueryAsync().ConfigureAwait(false);
        }

        private async Task ReadValueInTransactionScope(SpannerConnection readConnection)
        {
            var cmd = CreateSelectAllCommandForKey(readConnection);
            using (var reader = await cmd.ExecuteReaderAsync())
            {
                if (await reader.ReadAsync())
                {
                    Assert.Equal(
                         _newestEntry.Value,
                        reader.GetFieldValue<string>(reader.GetOrdinal("StringValue")));
                }
            }
        }

        [Fact]
        public async Task ScopeCompleteWithReadDoesntThrow()
        {
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                using (var connection = _fixture.GetConnection())
                {
                    await connection.OpenAsReadOnlyAsync();
                    var cmd = CreateSelectAllCommandForKey(connection);
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            Assert.Equal(
                                _newestEntry.Value, reader.GetFieldValue<string>(reader.GetOrdinal("StringValue")));
                        }
                    }
                    scope.Complete();
                }
            }
        }

        [Fact]
        public async Task ScopeCompleteWithNoWritesDoesntThrow()
        {
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                using (var connection = _fixture.GetConnection())
                {
                    await connection.OpenAsync();
                    scope.Complete();
                }
            }
        }

        [Fact]
        public async Task ScopeCompleteWithTwoReadsDoesntThrow()
        {
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            using (var readConnection1 = _fixture.GetConnection())
            using (var readConnection2 = _fixture.GetConnection())
            {
                await readConnection1.OpenAsReadOnlyAsync();
                await readConnection2.OpenAsReadOnlyAsync();

                await ReadValueInTransactionScope(readConnection1);
                await ReadValueInTransactionScope(readConnection2);
                scope.Complete();
            }
        }

        [Fact]
        public async Task ScopeCompleteWithOneReadOneWriteThrows()
        {
            await Assert.ThrowsAsync<TransactionAbortedException>(
                async () =>
                {
                    using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                    using (var readConnection = _fixture.GetConnection())
                    using (var writeConnection = _fixture.GetConnection())
                    {
                        await readConnection.OpenAsReadOnlyAsync();
                        await writeConnection.OpenAsync();

                        await ReadValueInTransactionScope(readConnection);
                        await UpdateValueInTransactionScope(writeConnection);
                        scope.Complete();
                    }
                });
        }

        [Fact]
        public async Task ScopeCompleteWithTwoWritesThrows()
        {
            await Assert.ThrowsAsync<TransactionAbortedException>(
                async () =>
                {
                    using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                    using (var writeConnection1 = _fixture.GetConnection())
                    using (var writeConnection2 = _fixture.GetConnection())
                    {
                        await writeConnection1.OpenAsync();
                        await writeConnection2.OpenAsync();

                        await UpdateValueInTransactionScope(writeConnection1);
                        await UpdateValueInTransactionScope(writeConnection2);

                        scope.Complete();
                    }
                });
        }
#endif

        [Fact]
        public async Task ReadStrongSingle()
        {
            using (var connection = _fixture.GetConnection())
            {
                await connection.OpenAsync();
                var cmd = CreateSelectAllCommandForKey(connection);
                using (var reader = await cmd.ExecuteReaderAsync(TimestampBound.Strong))
                {
                    if (await reader.ReadAsync())
                    {
                        Assert.Equal(_newestEntry.Value, reader.GetFieldValue<string>(reader.GetOrdinal("StringValue")));
                    }
                }
            }
        }

        private class HistoryEntry
        {
            public string Value { get; }
            public DateTime Timestamp { get; }

            public HistoryEntry(string value, DateTime timestamp)
            {
                Value = value;
                Timestamp = timestamp;
            }
        }
    }
}
