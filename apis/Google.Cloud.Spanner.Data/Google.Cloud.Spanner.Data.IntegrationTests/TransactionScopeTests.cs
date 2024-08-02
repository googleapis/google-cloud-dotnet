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

using Google.Cloud.ClientTesting;
using Google.Cloud.Spanner.Data.CommonTesting;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    /// <summary>
    /// Tests for the .NET ambient transaction management implementation.
    /// </summary>
    [PerformanceLog]
    [Collection(nameof(TransactionTableFixture))]
    [CommonTestDiagnostics]
    public class TransactionScopeTests : TransactionTestBase
    {
        public TransactionScopeTests(TransactionTableFixture fixture) : base(fixture)
        {
        }

        private async Task UpdateValueAsync(SpannerConnection writeConnection)
        {
            var writeCommand = writeConnection.CreateUpdateCommand(_fixture.TableName);
            writeCommand.Parameters.Add("k", SpannerDbType.String, _key);
            writeCommand.Parameters.Add("Int64Value", SpannerDbType.Int64, 0);
            await writeCommand.ExecuteNonQueryAsync().ConfigureAwait(false);
        }

        private void UpdateValue(SpannerConnection writeConnection)
        {
            var writeCommand = writeConnection.CreateUpdateCommand(_fixture.TableName);
            writeCommand.Parameters.Add("k", SpannerDbType.String, _key);
            writeCommand.Parameters.Add("Int64Value", SpannerDbType.Int64, 0);
            writeCommand.ExecuteNonQuery();
        }

        private async Task AssertReadLatestValueAsync(SpannerConnection readConnection)
        {
            var cmd = CreateSelectAllCommandForKey(readConnection);
            using (var reader = await cmd.ExecuteReaderAsync())
            {
                Assert.True(await reader.ReadAsync());
                string expected = _newestEntry.Value;
                string actual = reader.GetFieldValue<string>(reader.GetOrdinal("StringValue"));
                Assert.Equal(expected, actual);
            }
        }


        private void AssertReadLatestValue(SpannerConnection readConnection)
        {
            var cmd = CreateSelectAllCommandForKey(readConnection);
            using (var reader = cmd.ExecuteReader())
            {
                Assert.True(reader.Read());
                string expected = _newestEntry.Value;
                string actual = reader.GetFieldValue<string>(reader.GetOrdinal("StringValue"));
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public async Task SingleRead_SuccessAsync()
        {
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                using (var connection = _fixture.GetConnection())
                {
                    await connection.OpenAsync(SpannerTransactionCreationOptions.ForTimestampBoundReadOnly(), options: null, cancellationToken: default);
                    AssertReadLatestValue(connection);
                    scope.Complete();
                }
            }
        }

        [Fact]
        public void SingleRead_Success()
        {
            using (var scope = new TransactionScope())
            {
                using (var connection = _fixture.GetConnection())
                {
                    connection.OpenAsync(SpannerTransactionCreationOptions.ForTimestampBoundReadOnly(), options: null, cancellationToken: default);
                    AssertReadLatestValue(connection);
                    scope.Complete();
                }
            }
        }

        [Fact]
        public async Task ReadWriteTransaction_NoWrites_SuccessAsync()
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
        public void ReadWriteTransaction_NoWrites_Success()
        {
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                using (var connection = _fixture.GetConnection())
                {
                    connection.Open();
                    scope.Complete();
                }
            }
        }

        [Fact]
        public async Task TwoReads_SuccessAsync()
        {
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            using (var readConnection1 = _fixture.GetConnection())
            using (var readConnection2 = _fixture.GetConnection())
            {
                await readConnection1.OpenAsync(SpannerTransactionCreationOptions.ForTimestampBoundReadOnly(), options: null, cancellationToken: default);
                await readConnection2.OpenAsync(SpannerTransactionCreationOptions.ForTimestampBoundReadOnly(), options: null, cancellationToken: default);

                await AssertReadLatestValueAsync(readConnection1);
                await AssertReadLatestValueAsync(readConnection2);
                scope.Complete();
            }
        }

        [Fact]
        public void TwoReads_Success()
        {
            using (var scope = new TransactionScope())
            using (var readConnection1 = _fixture.GetConnection())
            using (var readConnection2 = _fixture.GetConnection())
            {
                readConnection1.OpenAsync(SpannerTransactionCreationOptions.ForTimestampBoundReadOnly(), options: null, cancellationToken: default);
                readConnection2.OpenAsync(SpannerTransactionCreationOptions.ForTimestampBoundReadOnly(), options: null, cancellationToken: default);

                AssertReadLatestValue(readConnection1);
                AssertReadLatestValue(readConnection2);
                scope.Complete();
            }
        }

        [Fact]
        public async Task OneReadOneWrite_ThrowsAsync()
        {
            await AssertDisposeThrowsAsync(async scope =>
            {
                using (var readConnection = _fixture.GetConnection())
                using (var writeConnection = _fixture.GetConnection())
                {
                    await readConnection.OpenAsync(SpannerTransactionCreationOptions.ForTimestampBoundReadOnly(), options: null, cancellationToken: default);
                    await writeConnection.OpenAsync();

                    await AssertReadLatestValueAsync(readConnection);
                    await UpdateValueAsync(writeConnection);
                    scope.Complete();
                }
            });
        }

        [Fact]
        public void OneReadOneWrite_Throws()
        {
            AssertDisposeThrows(scope =>
            {
                using (var readConnection = _fixture.GetConnection())
                using (var writeConnection = _fixture.GetConnection())
                {
                    readConnection.OpenAsync(SpannerTransactionCreationOptions.ForTimestampBoundReadOnly(), options: null, cancellationToken: default);
                    writeConnection.Open();

                    AssertReadLatestValue(readConnection);
                    UpdateValue(writeConnection);
                    scope.Complete();
                }
            });
        }

        [Fact]
        public async Task OneWrite_SuccessAsync()
        {
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            using (var writeConnection = _fixture.GetConnection())
            {
                await writeConnection.OpenAsync();
                await UpdateValueAsync(writeConnection);
                scope.Complete();
            }
        }

        [Fact]
        public void OneWrite_Success()
        {
            using (var scope = new TransactionScope())
            using (var writeConnection = _fixture.GetConnection())
            {
                writeConnection.Open();
                UpdateValue(writeConnection);
                scope.Complete();
            }
        }

        [Fact]
        public async Task TwoWritesDifferentTransactions_ThrowsAsync()
        {
            await AssertDisposeThrowsAsync(async scope =>
            {
                using (var writeConnection1 = _fixture.GetConnection())
                using (var writeConnection2 = _fixture.GetConnection())
                {
                    await writeConnection1.OpenAsync();
                    await writeConnection2.OpenAsync();

                    await UpdateValueAsync(writeConnection1);
                    await UpdateValueAsync(writeConnection2);

                    scope.Complete();
                }
            });
        }

        [Fact]
        public void TwoWritesDifferentTransactions_Throws()
        {
            AssertDisposeThrows(scope =>
            {
                using (var writeConnection1 = _fixture.GetConnection())
                using (var writeConnection2 = _fixture.GetConnection())
                {
                    writeConnection1.Open();
                    writeConnection2.Open();

                    UpdateValue(writeConnection1);
                    UpdateValue(writeConnection2);

                    scope.Complete();
                }
            });
        }

        // The second transaction will fail to prepare; these tests validate that all three transactions
        // are cleaned up.
        [Fact]
        public async Task ThreeWritesDifferentTransactions_ThrowsAsync()
        {
            await AssertDisposeThrowsAsync(async scope =>
            {
                using (var writeConnection1 = _fixture.GetConnection())
                using (var writeConnection2 = _fixture.GetConnection())
                using (var writeConnection3 = _fixture.GetConnection())
                {
                    await writeConnection1.OpenAsync();
                    await writeConnection2.OpenAsync();
                    await writeConnection3.OpenAsync();

                    await UpdateValueAsync(writeConnection1);
                    await UpdateValueAsync(writeConnection2);
                    await UpdateValueAsync(writeConnection3);

                    scope.Complete();
                }
            });
        }

        [Fact]
        public void ThreeWritesDifferentTransactions_Throws()
        {
            AssertDisposeThrows(scope =>
            {
                using (var writeConnection1 = _fixture.GetConnection())
                using (var writeConnection2 = _fixture.GetConnection())
                using (var writeConnection3 = _fixture.GetConnection())
                {
                    writeConnection1.Open();
                    writeConnection2.Open();
                    writeConnection3.Open();

                    UpdateValue(writeConnection1);
                    UpdateValue(writeConnection2);
                    UpdateValue(writeConnection3);

                    scope.Complete();
                }
            });
        }

        // Note: this is deliberately parallel to TransactionTests.MultiTableWrite.
        // It is intended to check that the same functionality works whether with an implicit
        // scoped transaction, or an explicit transaction.
        [Fact]
        public void MultiTableWrite()
        {
            // For simplicity, use a new key so that this test is entirely self-contained.
            string key = IdGenerator.FromGuid();
            RetryHelpers.ExecuteWithRetry(() =>
            {
                using (var scope = new TransactionScope())
                {
                    using (var connection = _fixture.GetConnection())
                    {
                        connection.Open();
                        using (var cmd1 = connection.CreateInsertCommand(_fixture.TableName))
                        {
                            cmd1.Parameters.Add("K", SpannerDbType.String).Value = key;
                            cmd1.Parameters.Add("StringValue", SpannerDbType.String).Value = "text";
                            cmd1.ExecuteNonQuery();
                        }

                        using (var cmd2 = connection.CreateInsertCommand(_fixture.TableName2))
                        {
                            cmd2.Parameters.Add("K", SpannerDbType.String).Value = key;
                            cmd2.Parameters.Add("Int64Value", SpannerDbType.Int64).Value = 50;
                            cmd2.ExecuteNonQuery();
                        }
                    }

                    scope.Complete();
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
        public async Task ParallelWriteAsync()
        {
            string[] keys = new string[] { IdGenerator.FromGuid(), IdGenerator.FromGuid(), IdGenerator.FromGuid() };
            await RetryHelpers.ExecuteWithRetryAsync(async () =>
            {
                using var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);
                using var connection = _fixture.GetConnection();
                await connection.OpenAsync();

                await Task.WhenAll(keys.Select(key =>
                {
                    using var cmd = connection.CreateInsertCommand(_fixture.TableName);
                    cmd.Parameters.Add("K", SpannerDbType.String).Value = key;
                    cmd.Parameters.Add("StringValue", SpannerDbType.String).Value = "text";
                    return cmd.ExecuteNonQueryAsync();
                }));
                scope.Complete();
            });

            // Read the inserted values.
            using var connection = _fixture.GetConnection();
            using var command = connection.CreateSelectCommand($"SELECT COUNT(*) AS C FROM {_fixture.TableName} WHERE K IN UNNEST(@Keys)");
            command.Parameters.Add("Keys", SpannerDbType.ArrayOf(SpannerDbType.String)).Value = keys;
            using var reader = command.ExecuteReader();

            Assert.True(reader.Read());
            Assert.Equal(keys.Length, reader.GetInt32(0));
        }

        private void AssertDisposeThrows(Action<TransactionScope> action)
        {
            var scope = new TransactionScope();
            try
            {
                action(scope);
            }
            finally
            {
                Assert.Throws<TransactionAbortedException>(() => scope.Dispose());
            }
        }

        private async Task AssertDisposeThrowsAsync(Func<TransactionScope, Task> action)
        {
            var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);
            try
            {
                await action(scope);
            }
            finally
            {
                Assert.Throws<TransactionAbortedException>(() => scope.Dispose());
            }
        }
    }
}
