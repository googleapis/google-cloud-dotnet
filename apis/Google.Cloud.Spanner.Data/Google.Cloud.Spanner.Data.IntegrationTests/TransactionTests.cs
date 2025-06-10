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

using Google.Api.Gax.Grpc;
using Google.Cloud.ClientTesting;
using Google.Cloud.Spanner.Data.CommonTesting;
using Google.Cloud.Spanner.V1.Internal.Logging;
using System;
using System.Data;
using System.Threading.Tasks;
using Xunit;
using WKT = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [PerformanceLog]
    [Collection(nameof(TransactionTableFixture))]
    [CommonTestDiagnostics]
    public class TransactionTests : TransactionTestBase
    {
        public TransactionTests(TransactionTableFixture fixture)
            : base(fixture)
        {
        }

        private async Task IncrementByOneAsync(SpannerConnection connection, bool orphanTransaction = false)
        {
            var retrySettings = RetrySettings.FromExponentialBackoff(
                maxAttempts: int.MaxValue,
                initialBackoff: TimeSpan.FromMilliseconds(250),
                maxBackoff: TimeSpan.FromSeconds(5),
                backoffMultiplier: 1.5,
                retryFilter: ignored => false,
                RetrySettings.RandomJitter);
            TimeSpan nextDelay = TimeSpan.Zero;
            SpannerException spannerException;
            DateTime deadline = DateTime.UtcNow.AddSeconds(30);

            while (true)
            {
                spannerException = null;
                try
                {
                    // We use manually created transactions here so the tests run on .NET Core.
                    using (var transaction = await connection.BeginTransactionAsync())
                    {
                        long current;
                        using (var cmd = connection.CreateSelectCommand($"SELECT Int64Value FROM {_fixture.TableName} WHERE K=@k"))
                        {
                            cmd.Parameters.Add("k", SpannerDbType.String, _key);
                            cmd.Transaction = transaction;
                            var fetched = await cmd.ExecuteScalarAsync().ConfigureAwait(false);
                            current = fetched is DBNull ? 0L : (long)fetched;
                        }
                        using (var cmd = connection.CreateUpdateCommand(_fixture.TableName))
                        {
                            cmd.Parameters.Add("k", SpannerDbType.String, _key);
                            cmd.Parameters.Add("Int64Value", SpannerDbType.Int64, current + 1);
                            cmd.Transaction = transaction;
                            await cmd.ExecuteNonQueryAsync().ConfigureAwait(false);
                            if (!orphanTransaction)
                            {
                                await transaction.CommitAsync().ConfigureAwait(false);
                            }
                        }
                    }
                    return;
                }
                // Keep trying for up to 30 seconds
                catch (SpannerException ex) when (ex.IsRetryable && DateTime.UtcNow < deadline)
                {
                    nextDelay = retrySettings.NextBackoff(nextDelay);
                    await Task.Delay(retrySettings.BackoffJitter.GetDelay(nextDelay));
                    spannerException = ex;
                }
            }
        }

        [Fact]
        public async Task Commit_ReturnsToPool()
        {
            using var connection = new SpannerConnection(_fixture.ConnectionString);
            await connection.OpenAsync();

            using var transaction = await connection.BeginTransactionAsync();
            using var command = connection.CreateSelectCommand($"SELECT Int64Value FROM {_fixture.TableName} WHERE K=@k");
            command.Parameters.Add("k", SpannerDbType.String, _key);
            command.Transaction = transaction;

            var value = await command.ExecuteScalarAsync();

            transaction.Commit();

            var poolStatistics = connection.GetSessionPoolSegmentStatistics();

            // Because the session is eagerly returned to the pool after a commit, there shouldn't
            // be any active sessions even before we dispose of the transaction explicitly.
            Assert.Equal(0, poolStatistics.ActiveSessionCount);
        }

        [Fact]
        public async Task Rollback_ReturnsToPool()
        {
            using var connection = new SpannerConnection(_fixture.ConnectionString);
            await connection.OpenAsync();

            using var transaction = await connection.BeginTransactionAsync();
            using var command = connection.CreateSelectCommand($"SELECT Int64Value FROM {_fixture.TableName} WHERE K=@k");
            command.Parameters.Add("k", SpannerDbType.String, _key);
            command.Transaction = transaction;

            var value = await command.ExecuteScalarAsync();

            transaction.Rollback();

            var poolStatistics = connection.GetSessionPoolSegmentStatistics();

            // Because the session is eagerly returned to the pool after a rollback, there shouldn't
            // be any active sessions even before we dispose of the transaction explicitly.
            Assert.Equal(0, poolStatistics.ActiveSessionCount);
        }

        [Fact]
        public async Task DetachOnDisposeTransactionIsDetached()
        {
            using var connection = new SpannerConnection(_fixture.ConnectionString);
            await connection.OpenAsync();

            using var transaction = await connection.BeginTransactionAsync(SpannerTransactionCreationOptions.ReadOnly.WithIsDetached(true), transactionOptions: null, cancellationToken: default);

            // We are testing (through the CommonTestsDiagnostics attribute) that there
            // are no active sessions or connections after we have disposed of both.
        }

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

                await RetryHelpers.ExecuteWithRetryAsync(async () =>
                {
                    using (var tx = await connection.BeginTransactionAsync())
                    {
                        // Because Cloud Spanner does not have "read your writes"
                        // to test any leaks, we must commit the transaction and then read it.
                        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => tx.CommitAsync());
                        Assert.Contains("no command execution has been attempted", exception.Message);
                    }
                });

                // The value should not be present in the table.
                using (var cmd = connection.CreateSelectCommand($"SELECT Int64Value FROM {_fixture.TableName} WHERE K=@k"))
                {
                    cmd.Parameters.Add("k", SpannerDbType.String, _key);
                    Assert.Equal(DBNull.Value, await cmd.ExecuteScalarAsync());
                }
            }
        }

        [Fact]
        [Trait(Constants.SupportedOnEmulator, Constants.No)]
        public async Task AbortedThrownCorrectly()
        {
            // Requires multiple read/write transactions which is not supported on the emulator.
            // connection 1 starts a transaction and reads
            // connection 2 starts a transaction and reads the same row
            // connection 1 writes and commits
            // connection 2 reads again -- abort should be thrown.

            // Note: deeply nested using statements to ensure that we dispose of everything even in the case of failure,
            // but we manually dispose of both tx1 and connection1.
            using (var connection1 = new SpannerConnection(_fixture.ConnectionString))
            {
                using (var connection2 = new SpannerConnection(_fixture.ConnectionString))
                {

                    await Task.WhenAll(connection1.OpenAsync(), connection2.OpenAsync());
                    using (var tx1 = await connection1.BeginTransactionAsync())
                    {

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
                        using (var tx2 = await connection2.BeginTransactionAsync())
                        {

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
                            using (var cmd = connection1.CreateUpdateCommand(_fixture.TableName))
                            {
                                cmd.Parameters.Add("k", SpannerDbType.String, _key);
                                cmd.Parameters.Add("Int64Value", SpannerDbType.Int64, 0);
                                cmd.Transaction = tx1;
                                await cmd.ExecuteNonQueryAsync();
                                await tx1.CommitAsync();
                                tx1.Dispose();
                            }
                            connection1.Dispose();

                            // TX2 READ AGAIN/THROWS
                            using (var cmd = CreateSelectAllCommandForKey(connection2))
                            {
                                cmd.Transaction = tx2;
                                using (var reader = await cmd.ExecuteReaderAsync())
                                {
                                    var thrownException = await Assert.ThrowsAsync<SpannerException>(() => reader.ReadAsync());
                                    Assert.True(thrownException.IsRetryable);
                                }
                            }
                        }
                    }
                }
            }
        }

        [Fact]
        [Trait(Constants.SupportedOnEmulator, Constants.No)]
        public async Task IsolationLevelBehavesCorrectly()
        {
            // Requires multiple read/write transactions which is not supported on the emulator.

            // Note: deeply nested using statements to ensure that we dispose of everything even in the case of failure,
            // but we manually dispose of both tx1 and connection1.
            using (var connection1 = new SpannerConnection(_fixture.ConnectionString))
            {
                using (var connection2 = new SpannerConnection(_fixture.ConnectionString))
                {

                    await Task.WhenAll(connection1.OpenAsync(), connection2.OpenAsync());
                    // TX1 has no IsolationLevel so default should be taken up
                    using (var tx1 = await connection1.BeginTransactionAsync())
                    {

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
                        // TX2 set with IsolationLevel RepeatableRead
                        using (var tx2 = await connection2.BeginTransactionAsync(SpannerTransactionCreationOptions.ReadWrite.WithIsolationLevel(IsolationLevel.RepeatableRead),
                transactionOptions: null, default))
                        {

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
                            using (var cmd = connection1.CreateUpdateCommand(_fixture.TableName))
                            {
                                cmd.Parameters.Add("k", SpannerDbType.String, _key);
                                cmd.Parameters.Add("Int64Value", SpannerDbType.Int64, 0);
                                cmd.Transaction = tx1;
                                await cmd.ExecuteNonQueryAsync();
                                await tx1.CommitAsync();
                                tx1.Dispose();
                            }
                            connection1.Dispose();

                            // TX2 READ again should not throw an exception
                            using (var cmd = CreateSelectAllCommandForKey(connection2))
                            {
                                cmd.Transaction = tx2;
                                using (var reader = await cmd.ExecuteReaderAsync())
                                {
                                    // Best we can do is assert the read is successful even after TX1 commits write as TX2 should have snapshot isolation
                                    Assert.True(await reader.ReadAsync());
                                }
                            }
                        }
                    }
                }
            }
        }

        [Fact]
        public async Task MultiWrite()
        {
            // To ensure good concurrency (ie that the transactions are not serial)
            // we'll preopen 5 transactions to ensure they have sessions and then start the increment
            // process
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
            await Task.WhenAll(tasks);

            // Now ensure we have the correct value
            using (var cmd = connections[0].CreateSelectCommand($"SELECT Int64Value FROM {_fixture.TableName} WHERE K=@k"))
            {
                cmd.Parameters.Add("k", SpannerDbType.String, _key);
                Assert.Equal(5, await cmd.ExecuteScalarAsync<long>());
            }

            for (var i = 0; i < concurrentThreads; i++)
            {
                connections[i].Dispose();
            }
        }

        [Fact]
        public void MultiTableWrite()
        {
            // For simplicity, use a new key so that this test is entirely self-contained.
            string key = IdGenerator.FromGuid();
            RetryHelpers.ExecuteWithRetry(() =>
            {
                using (var connection = _fixture.GetConnection())
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        using (var cmd1 = connection.CreateInsertCommand(_fixture.TableName))
                        {
                            cmd1.Transaction = transaction;
                            cmd1.Parameters.Add("K", SpannerDbType.String).Value = key;
                            cmd1.Parameters.Add("StringValue", SpannerDbType.String).Value = "text";
                            cmd1.ExecuteNonQuery();
                        }

                        using (var cmd2 = connection.CreateInsertCommand(_fixture.TableName2))
                        {
                            cmd2.Transaction = transaction;
                            cmd2.Parameters.Add("K", SpannerDbType.String).Value = key;
                            cmd2.Parameters.Add("Int64Value", SpannerDbType.Int64).Value = 50;
                            cmd2.ExecuteNonQuery();
                        }

                        // Commit mutations from both commands, atomically.
                        transaction.Commit();
                    }
                }
            });

            // Read the values from both tables
            using (var connection = _fixture.GetConnection())
            {
                using (var command = connection.CreateSelectCommand($"SELECT * FROM {_fixture.TableName} WHERE K=@Key"))
                {
                    command.Parameters.Add("Key", SpannerDbType.String).Value = key;
                    using (var reader = command.ExecuteReader())
                    {
                        Assert.True(reader.Read());
                        Assert.Equal("text", reader["StringValue"]);
                        Assert.False(reader.Read());
                    }
                }

                using (var command = connection.CreateSelectCommand($"SELECT * FROM {_fixture.TableName2} WHERE K=@Key"))
                {
                    command.Parameters.Add("Key", SpannerDbType.String).Value = key;
                    using (var reader = command.ExecuteReader())
                    {
                        Assert.True(reader.Read());
                        Assert.Equal(50L, reader["Int64Value"]);
                        Assert.False(reader.Read());
                    }
                }
            }
        }

        [Fact]
        public async Task ReadExact()
        {
            using (var connection = _fixture.GetConnection())
            {
                await connection.OpenAsync();
                var targetReadTimestamp = _fixture.TimestampBeforeEntries;
                var bound = SpannerTransactionCreationOptions.ForTimestampBoundReadOnly(TimestampBound.OfReadTimestamp(targetReadTimestamp));
                using (var tx = await connection.BeginTransactionAsync(bound, transactionOptions: null, cancellationToken: default))
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
                cmd.EphemeralTransactionCreationOptions = SpannerTransactionCreationOptions.ForTimestampBoundReadOnly(TimestampBound.OfReadTimestamp(_oldestEntry.Timestamp));
                using (var reader = await cmd.ExecuteReaderAsync())
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

                // Can't use MinReadTimestamp to create a transaction
                var bound = SpannerTransactionCreationOptions.ForTimestampBoundReadOnly(TimestampBound.OfMinReadTimestamp(_newestEntry.Timestamp));
                await Assert.ThrowsAsync<ArgumentException>(() => connection.BeginTransactionAsync(bound, transactionOptions: null, cancellationToken: default));

                var cmd = CreateSelectAllCommandForKey(connection);
                cmd.EphemeralTransactionCreationOptions = bound;
                using (var reader = await cmd.ExecuteReaderAsync())
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
                var bound = SpannerTransactionCreationOptions.ForTimestampBoundReadOnly(TimestampBound.OfExactStaleness(_fixture.Staleness));
                using (var tx = await connection.BeginTransactionAsync(bound, transactionOptions: null, cancellationToken: default))
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
                cmd.EphemeralTransactionCreationOptions = SpannerTransactionCreationOptions.ForTimestampBoundReadOnly(TimestampBound.OfExactStaleness(_fixture.Staleness));
                using (var reader = await cmd.ExecuteReaderAsync())
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

                // Can't use MaxStaleness to create a transaction
                var staleBound = SpannerTransactionCreationOptions.ForTimestampBoundReadOnly(TimestampBound.OfMaxStaleness(_fixture.Staleness));
                await Assert.ThrowsAsync<ArgumentException>(() => connection.BeginTransactionAsync(staleBound, transactionOptions: null, cancellationToken: default));

                var cmd = CreateSelectAllCommandForKey(connection);
                cmd.EphemeralTransactionCreationOptions = SpannerTransactionCreationOptions.ForTimestampBoundReadOnly(TimestampBound.OfMaxStaleness(TimeSpan.FromMilliseconds(5)));
                using (var reader = await cmd.ExecuteReaderAsync())
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
                var strong = SpannerTransactionCreationOptions.ForTimestampBoundReadOnly(TimestampBound.Strong);
                using (var tx = await connection.BeginTransactionAsync(strong, transactionOptions: null, cancellationToken: default))
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

        [Fact]
        public async Task ReadStrongSingle()
        {
            using (var connection = _fixture.GetConnection())
            {
                await connection.OpenAsync();
                var cmd = CreateSelectAllCommandForKey(connection);
                cmd.EphemeralTransactionCreationOptions = SpannerTransactionCreationOptions.ForTimestampBoundReadOnly(TimestampBound.Strong);
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        Assert.Equal(_newestEntry.Value, reader.GetFieldValue<string>(reader.GetOrdinal("StringValue")));
                    }
                }
            }
        }

        [Fact]
        public async Task ExactReadSinglueUseWithoutReturnReadTimestamp()
        {
            using (var connection = _fixture.GetConnection())
            {
                await connection.OpenAsync();
                var cmd = CreateSelectAllCommandForKey(connection);
                cmd.EphemeralTransactionCreationOptions = SpannerTransactionCreationOptions.ForTimestampBoundReadOnly(TimestampBound.OfReadTimestamp(_oldestEntry.Timestamp));
                using (var reader = (SpannerDataReader)(await cmd.ExecuteReaderAsync()))
                {
                    Assert.Null(reader.GetReadTimestamp());
                    if (await reader.ReadAsync())
                    {
                        Assert.Equal(_oldestEntry.Value, reader.GetFieldValue<string>(reader.GetOrdinal("StringValue")));
                    }
                }
            }
        }

        [Fact]
        public async Task ExactReadSinglueUseWithReturnReadTimestamp()
        {
            using (var connection = _fixture.GetConnection())
            {
                await connection.OpenAsync();
                var cmd = CreateSelectAllCommandForKey(connection);
                cmd.EphemeralTransactionCreationOptions = SpannerTransactionCreationOptions.ForTimestampBoundReadOnly(
                    TimestampBound.OfReadTimestamp(_oldestEntry.Timestamp).WithReturnReadTimestamp(true));
                using (var reader = (SpannerDataReader)(await cmd.ExecuteReaderAsync()))
                {
                    Assert.Equal(WKT::Timestamp.FromDateTime(_oldestEntry.Timestamp), reader.GetReadTimestamp());
                    if (await reader.ReadAsync())
                    {
                        Assert.Equal(_oldestEntry.Value, reader.GetFieldValue<string>(reader.GetOrdinal("StringValue")));
                    }
                }
            }
        }

        [Fact]
        public async Task ExactReadMultiUseWithoutReturnReadTimestamp()
        {
            using (var connection = _fixture.GetConnection())
            {
                await connection.OpenAsync();
                var targetReadTimestamp = _fixture.TimestampBeforeEntries;
                var bound = SpannerTransactionCreationOptions.ForTimestampBoundReadOnly(TimestampBound.OfReadTimestamp(targetReadTimestamp));
                using (var tx = await connection.BeginTransactionAsync(bound, transactionOptions: null, cancellationToken: default))
                {
                    Assert.Equal(TransactionMode.ReadOnly, tx.Mode);
                    Assert.Equal(targetReadTimestamp, tx.TimestampBound.Timestamp);
                    Assert.False(tx.TimestampBound.ReturnReadTimestamp);

                    var cmd = CreateSelectAllCommandForKey(connection);
                    cmd.Transaction = tx;
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        Assert.Null(reader.GetReadTimestamp());
                        Assert.False(
                            await reader.ReadAsync(),
                            "no data should be here from yesterday!");
                    }
                }
            }
        }

        [Fact]
        public async Task ExactReadMultiUseWithReturnReadTimestamp()
        {
            using (var connection = _fixture.GetConnection())
            {
                await connection.OpenAsync();
                var targetReadTimestamp = _fixture.TimestampBeforeEntries;
                var bound = SpannerTransactionCreationOptions.ForTimestampBoundReadOnly(
                    TimestampBound.OfReadTimestamp(targetReadTimestamp).WithReturnReadTimestamp(true));
                using (var tx = await connection.BeginTransactionAsync(bound, transactionOptions: null, cancellationToken: default))
                {
                    Assert.Equal(TransactionMode.ReadOnly, tx.Mode);
                    Assert.Equal(targetReadTimestamp, tx.TimestampBound.Timestamp);
                    Assert.True(tx.TimestampBound.ReturnReadTimestamp);

                    var cmd = CreateSelectAllCommandForKey(connection);
                    cmd.Transaction = tx;
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        Assert.Equal(WKT::Timestamp.FromDateTime(targetReadTimestamp), reader.GetReadTimestamp());
                        Assert.False(
                            await reader.ReadAsync(),
                            "no data should be here from yesterday!");
                    }
                }
            }
        }

        /// <summary>
        /// Simple extension of DefaultLogger that also keeps a reference to the last logged CommitResponse.
        /// </summary>
        internal class CommitStatsCapturerLogger : DefaultLogger
        {
            internal V1.CommitResponse LastCommitResponse { get; private set; }

            public override void LogCommitStats(V1.CommitRequest request, V1.CommitResponse response)
            {
                LastCommitResponse = response;
                base.LogCommitStats(request, response);
            }
        }

        [Fact]
        [Trait(Constants.SupportedOnEmulator, Constants.No)]
        public async Task ReturnCommitStats_ExplicitTransaction()
        {
            // Emulator does not yet support CommitStats.
            CommitStatsCapturerLogger logger = new CommitStatsCapturerLogger();
            string key = IdGenerator.FromGuid();
            await RetryHelpers.ExecuteWithRetryAsync(async () =>
            {
                using (var connection = _fixture.GetConnection(logger, logCommitStats: true))
                {
                    await connection.OpenAsync();
                    using (var transaction = connection.BeginTransaction())
                    {
                        using (var cmd1 = connection.CreateInsertCommand(_fixture.TableName))
                        {
                            cmd1.Transaction = transaction;
                            cmd1.Parameters.Add("K", SpannerDbType.String).Value = key;
                            cmd1.Parameters.Add("StringValue", SpannerDbType.String).Value = "text";
                            await cmd1.ExecuteNonQueryAsync();
                        }

                        using (var cmd2 = connection.CreateInsertCommand(_fixture.TableName2))
                        {
                            cmd2.Transaction = transaction;
                            cmd2.Parameters.Add("K", SpannerDbType.String).Value = key;
                            cmd2.Parameters.Add("Int64Value", SpannerDbType.Int64).Value = 50;
                            await cmd2.ExecuteNonQueryAsync();
                        }

                        await transaction.CommitAsync();
                        // MutationCount == 4, as we inserted 2 rows with 2 columns each.
                        Assert.Equal(4, logger.LastCommitResponse?.CommitStats?.MutationCount);
                    }
                }
            });
        }

        [Fact]
        [Trait(Constants.SupportedOnEmulator, Constants.No)]
        public async Task ReturnCommitStats_EphemeralTransaction()
        {
            // Emulator does not yet support CommitStats.
            CommitStatsCapturerLogger logger = new CommitStatsCapturerLogger();
            string key = IdGenerator.FromGuid();
            await RetryHelpers.ExecuteWithRetryAsync(async () =>
            {
                using (var connection = _fixture.GetConnection(logger, logCommitStats: true))
                {
                    await connection.OpenAsync();

                    using (var cmd1 = connection.CreateInsertCommand(_fixture.TableName))
                    {
                        cmd1.Parameters.Add("K", SpannerDbType.String).Value = key;
                        cmd1.Parameters.Add("StringValue", SpannerDbType.String).Value = "text";
                        await cmd1.ExecuteNonQueryAsync();
                    }

                    // MutationCount == 2, as we inserted 1 row with 2 columns each.
                    Assert.Equal(2, logger.LastCommitResponse?.CommitStats?.MutationCount);
                }
            });
        }
    }
}
