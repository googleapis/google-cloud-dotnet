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

using Google.Cloud.Spanner.Data.CommonTesting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    /// <summary>
    /// Note: most tests use ephemeral transactions. Only tests that need to exercise rollback,
    /// query-in-transaction or multiple-DML scenarios use explicit transactions.
    /// </summary>
    [Collection(nameof(DmlTableFixture))]
    public class DmlTests
    {
        private readonly DmlTableFixture _fixture;

        public enum TransactionType
        {
            EphemeralTransaction,
            ExplicitTransaction,
            RetryableTransaction
        }

        public DmlTests(DmlTableFixture fixture) => _fixture = fixture;

        [Fact]
        public void Update()
        {
            string key = _fixture.CreateTestRows();
            using (var connection = _fixture.GetConnection())
            {
                RetryHelpers.ExecuteWithRetry(() =>
                {
                    string dml = $"UPDATE {_fixture.TableName} SET Value = OriginalValue + 1 WHERE UpdateMe AND Key=@key";
                    using (var command = connection.CreateDmlCommand(dml))
                    {
                        command.Parameters.Add("key", SpannerDbType.String, key);
                        Assert.Equal(2, command.ExecuteNonQuery());
                    }
                });
            }
            var actual = _fixture.FetchValues(key);
            var expected = new Dictionary<int, int>
            {
                { 0, 0 }, // Not updated
                { 1, 2 }, // Updated
                { 2, 2 }, // Not updated
                { 3, 3 }, // Not updated
                { 4, 5 }  // Updated
            };
            Assert.Equal(expected, actual);
        }

        // Just a single async test to make sure that works just as well. They go through the same code pretty rapidly.
        [Fact]
        public async Task Update_Async()
        {
            string key = _fixture.CreateTestRows();
            using (var connection = _fixture.GetConnection())
            {
                await RetryHelpers.ExecuteWithRetryAsync(async () =>
                {
                    string dml = $"UPDATE {_fixture.TableName} SET Value = OriginalValue + 1 WHERE UpdateMe AND Key=@key";
                    using (var command = connection.CreateDmlCommand(dml))
                    {
                        command.Parameters.Add("key", SpannerDbType.String, key);
                        Assert.Equal(2, await command.ExecuteNonQueryAsync());
                    }
                });
            }
            var actual = _fixture.FetchValues(key);
            var expected = new Dictionary<int, int>
            {
                { 0, 0 }, // Not updated
                { 1, 2 }, // Updated
                { 2, 2 }, // Not updated
                { 3, 3 }, // Not updated
                { 4, 5 }  // Updated
            };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Delete()
        {
            string key = _fixture.CreateTestRows();
            using (var connection = _fixture.GetConnection())
            {
                RetryHelpers.ExecuteWithRetry(() =>
                {
                    string dml = $"DELETE FROM {_fixture.TableName} WHERE DeleteMe AND Key=@key";
                    using (var command = connection.CreateDmlCommand(dml))
                    {
                        command.Parameters.Add("key", SpannerDbType.String, key);
                        Assert.Equal(2, command.ExecuteNonQuery());
                    }
                });
            }
            var actual = _fixture.FetchValues(key);
            var expected = new Dictionary<int, int>
            {
                { 0, 0 },
                { 1, 1 },
                { 3, 3 },
                // 2 and 4 are deleted
            };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InsertWithValues()
        {
            string key = _fixture.CreateTestRows();
            using (var connection = _fixture.GetConnection())
            {
                RetryHelpers.ExecuteWithRetry(() =>
                {
                    string dml = $"INSERT INTO {_fixture.TableName} (Key, OriginalValue, Value) VALUES (@key, @ov1, @v1), (@key, @ov2, @v2)";
                    using (var command = connection.CreateDmlCommand(dml))
                    {
                        command.Parameters.Add("key", SpannerDbType.String, key);
                        command.Parameters.Add("ov1", SpannerDbType.Int64, 5);
                        command.Parameters.Add("v1", SpannerDbType.Int64, 10);
                        command.Parameters.Add("ov2", SpannerDbType.Int64, 6);
                        command.Parameters.Add("v2", SpannerDbType.Int64, 20);
                        Assert.Equal(2, command.ExecuteNonQuery());
                    }
                });
            }
            var actual = _fixture.FetchValues(key);
            var expected = new Dictionary<int, int>
            {
                { 0, 0 },
                { 1, 1 },
                { 2, 2 },
                { 3, 3 },
                { 4, 4 },
                { 5, 10 }, // New row
                { 6, 20 }, // New row
            };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InsertWithQuery()
        {
            string key = _fixture.CreateTestRows();
            using (var connection = _fixture.GetConnection())
            {
                RetryHelpers.ExecuteWithRetry(() =>
                {
                    // Slightly odd choice here: "OriginalValue" has to be unique, so we end up with the inserted Value being the real original value.
                    string dml = $"INSERT INTO {_fixture.TableName} (Key, OriginalValue, Value) SELECT Key, OriginalValue + 10, Value FROM {_fixture.TableName} WHERE CopyMe AND KEY=@Key";
                    using (var command = connection.CreateDmlCommand(dml))
                    {
                        command.Parameters.Add("key", SpannerDbType.String, key);
                        Assert.Equal(2, command.ExecuteNonQuery());
                    }
                });
            }
            var actual = _fixture.FetchValues(key);
            var expected = new Dictionary<int, int>
            {
                { 0, 0 },
                { 1, 1 },
                { 2, 2 },
                { 3, 3 },
                { 4, 4 },
                { 13, 3 }, // Copied
                { 14, 4 } // Copied
            };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InvalidQuery()
        {
            string key = _fixture.CreateTestRows();
            using (var connection = _fixture.GetConnection())
            {
                string dml = $"UPDATE {_fixture.TableName} SET FOO = BAR";
                using (var command = connection.CreateDmlCommand(dml))
                {
                    command.Parameters.Add("key", SpannerDbType.String, key);
                    var exception = Assert.Throws<SpannerException>(() => command.ExecuteNonQuery());
                    Assert.Equal(ErrorCode.InvalidArgument, exception.ErrorCode);
                }
            }
        }

        [Fact]
        public void InvalidMethodCalls()
        {
            string key = _fixture.CreateTestRows();
            using (var connection = _fixture.GetConnection())
            {
                string dml = $"DELETE FROM {_fixture.TableName} WHERE DeleteMe AND Key=@key";
                using (var command = connection.CreateDmlCommand(dml))
                {
                    command.Parameters.Add("key", SpannerDbType.String, key);
                    Assert.Throws<InvalidOperationException>(() => command.ExecuteScalar());
                }
            }
        }

        [Fact]
        public async Task ReadOnlyTransaction_Invalid()
        {
            string key = _fixture.CreateTestRows();
            using (var connection = _fixture.GetConnection())
            {
                connection.Open();
                using (var transaction = await connection.BeginTransactionAsync(SpannerTransactionCreationOptions.ReadOnly, transactionOptions: null, cancellationToken: default))
                {
                    string dml = $"DELETE FROM {_fixture.TableName} WHERE DeleteMe AND Key=@key";
                    using (var command = connection.CreateDmlCommand(dml))
                    {
                        command.Transaction = transaction;
                        command.Parameters.Add("key", SpannerDbType.String, key);
                        Assert.Throws<InvalidOperationException>(() => command.ExecuteNonQuery());
                    }
                }
            }
        }

        [Fact]
        public void MultipleDmlStatements()
        {
            string key = _fixture.CreateTestRows();
            using (var connection = _fixture.GetConnection())
            {
                connection.Open();
                RetryHelpers.ExecuteWithRetry(() =>
                {
                    using (var transaction = connection.BeginTransaction())
                    {
                        // First we update the rows to add 1, then we multiply that value by 2.
                        string dml = $"UPDATE {_fixture.TableName} SET Value = OriginalValue + 1 WHERE UpdateMe AND Key=@key";
                        using (var command = connection.CreateDmlCommand(dml))
                        {
                            command.Transaction = transaction;
                            command.Parameters.Add("key", SpannerDbType.String, key);
                            Assert.Equal(2, command.ExecuteNonQuery());
                            command.CommandText = $"UPDATE {_fixture.TableName} SET Value = Value * 2 WHERE UpdateMe AND Key=@key";
                            Assert.Equal(2, command.ExecuteNonQuery());
                            transaction.Commit();
                        }
                    }
                });
            }
            var actual = _fixture.FetchValues(key);
            var expected = new Dictionary<int, int>
            {
                { 0, 0 }, // Not updated
                { 1, 4 }, // Updated
                { 2, 2 }, // Not updated
                { 3, 3 }, // Not updated
                { 4, 10 }  // Updated
            };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InsertAndUpdateWithQuery()
        {
            string key = _fixture.CreateTestRows();
            using (var connection = _fixture.GetConnection())
            {
                RetryHelpers.ExecuteWithRetry(() =>
                {
                    string dml1 = $"INSERT INTO {_fixture.TableName} (Key, OriginalValue, Value) SELECT Key, OriginalValue + 10, Value FROM {_fixture.TableName} WHERE CopyMe AND KEY=@Key";
                    using (var command = connection.CreateDmlCommand(dml1))
                    {
                        command.Parameters.Add("key", SpannerDbType.String, key);
                        Assert.Equal(2, command.ExecuteNonQuery());
                    }

                    string dml2 = $"UPDATE {_fixture.TableName} SET Value = Value * 2 WHERE KEY=@Key AND OriginalValue > 10";
                    using (var command = connection.CreateDmlCommand(dml2))
                    {
                        command.Parameters.Add("key", SpannerDbType.String, key);
                        Assert.Equal(2, command.ExecuteNonQuery());
                    }
                });
            }
            var actual = _fixture.FetchValues(key);
            var expected = new Dictionary<int, int>
            {
                { 0, 0 },
                { 1, 1 },
                { 2, 2 },
                { 3, 3 },
                { 4, 4 },
                { 13, 6 }, // Inserted then updated
                { 14, 8 } // Inserted then updated
            };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DmlResultsVisibleWithinTransaction()
        {
            string key = _fixture.CreateTestRows();
            Dictionary<int, int> fetchedWithinTransaction = null;
            using (var connection = _fixture.GetConnection())
            {
                connection.Open();
                RetryHelpers.ExecuteWithRetry(() =>
                {
                    using (var transaction = connection.BeginTransaction())
                    {
                        string dml = $"UPDATE {_fixture.TableName} SET Value = OriginalValue + 1 WHERE UpdateMe AND Key=@key";
                        using (var command = connection.CreateDmlCommand(dml))
                        {
                            command.Transaction = transaction;
                            command.Parameters.Add("key", SpannerDbType.String, key);
                            Assert.Equal(2, command.ExecuteNonQuery());
                            fetchedWithinTransaction = _fixture.FetchValues(key, transaction);
                            transaction.Commit();
                        }
                    }
                });
            }
            var fetchedAfterTransaction = _fixture.FetchValues(key);
            var expected = new Dictionary<int, int>
            {
                { 0, 0 }, // Not updated
                { 1, 2 }, // Updated
                { 2, 2 }, // Not updated
                { 3, 3 }, // Not updated
                { 4, 5 }  // Updated
            };
            Assert.Equal(expected, fetchedAfterTransaction);
            Assert.Equal(expected, fetchedWithinTransaction);
        }

        [Fact]
        public void Rollback()
        {
            string key = _fixture.CreateTestRows();
            using (var connection = _fixture.GetConnection())
            {
                connection.Open();
                RetryHelpers.ExecuteWithRetry(() =>
                {
                    using (var transaction = connection.BeginTransaction())
                    {
                        string dml = $"UPDATE {_fixture.TableName} SET Value = OriginalValue + 1 WHERE UpdateMe AND Key=@key";
                        using (var command = connection.CreateDmlCommand(dml))
                        {
                            command.Transaction = transaction;
                            command.Parameters.Add("key", SpannerDbType.String, key);
                            Assert.Equal(2, command.ExecuteNonQuery());
                            transaction.Rollback();
                        }
                    }
                });
            }
            var actual = _fixture.FetchValues(key);
            // All the original values.
            var expected = new Dictionary<int, int>
            {
                { 0, 0 },
                { 1, 1 },
                { 2, 2 },
                { 3, 3 },
                { 4, 4 }
            };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DmlThenRawMutations()
        {
            string key = _fixture.CreateTestRows();
            using (var connection = _fixture.GetConnection())
            {
                connection.Open();
                string dml = $"INSERT INTO {_fixture.TableName} (Key, OriginalValue, Value) VALUES (@key, @ov1, @v1)";
                RetryHelpers.ExecuteWithRetry(() =>
                {
                    using (var transaction = connection.BeginTransaction())
                    {
                        using (var command = connection.CreateDmlCommand(dml))
                        {
                            command.Transaction = transaction;
                            command.Parameters.Add("key", SpannerDbType.String, key);
                            command.Parameters.Add("ov1", SpannerDbType.Int64, 5);
                            command.Parameters.Add("v1", SpannerDbType.Int64, 10);
                            Assert.Equal(1, command.ExecuteNonQuery());
                        }
                        using (var command = connection.CreateInsertCommand(_fixture.TableName))
                        {
                            command.Transaction = transaction;
                            command.Parameters.Add("Key", SpannerDbType.String, key);
                            command.Parameters.Add("OriginalValue", SpannerDbType.Int64, 7);
                            command.Parameters.Add("Value", SpannerDbType.Int64, 100);
                            Assert.Equal(1, command.ExecuteNonQuery());
                        }
                        transaction.Commit();
                    }
                });
            }
            var actual = _fixture.FetchValues(key);
            var expected = new Dictionary<int, int>
            {
                { 0, 0 },
                { 1, 1 },
                { 2, 2 },
                { 3, 3 },
                { 4, 4 },
                { 5, 10 }, // New row from DML
                { 7, 100 }, // New row from "raw" mutation
            };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PartitionedUpdate_Small()
        {
            string key = _fixture.CreateTestRows();
            string table = _fixture.TableName;
            using (var connection = _fixture.GetConnection())
            {
                RetryHelpers.ExecuteWithRetry(() =>
                {
                    string dml = $"UPDATE {table} SET {table}.Value = {table}.OriginalValue + 1 WHERE {table}.UpdateMe AND {table}.Key=@key";
                    using (var command = connection.CreateDmlCommand(dml))
                    {
                        command.Parameters.Add("key", SpannerDbType.String, key);
                        Assert.Equal(2L, command.ExecutePartitionedUpdate());
                    }
                });
            }
            var actual = _fixture.FetchValues(key);
            var expected = new Dictionary<int, int>
            {
                { 0, 0 }, // Not updated
                { 1, 2 }, // Updated
                { 2, 2 }, // Not updated
                { 3, 3 }, // Not updated
                { 4, 5 }  // Updated
            };
            Assert.Equal(expected, actual);
        }

        // Until we have a large test database to test against, this is a reasonable starting point.
        // It takes about 5 minutes to run though, which is too long for a single test on every test run.
        [Fact(Skip = "Long-running")]
        public void PartitionedUpdate_Medium()
        {
            string key = $"{nameof(PartitionedUpdate_Medium)} - {Guid.NewGuid()}";
            string table = _fixture.TableName;

            // First insert 1000 rows with "low" values, then add 100,000 to each value.
            // We should end up with 0 rows with "low" values, and 1000 rows with "high" values
            int rowsPerInsertBatch = 10;
            int insertBatches = 100;
            int totalRows = rowsPerInsertBatch * insertBatches;
            int amountToAdd = 100_000;

            // Check that we'll be adding enough to distinguish between non-updated and updated rows.
            Assert.True(amountToAdd > totalRows);

            int row = 1;
            for (int i = 0; i < insertBatches; i++)
            {
                RetryHelpers.ExecuteWithRetry(() =>
                {
                    using (var connection = _fixture.GetConnection())
                    {
                        connection.Open();
                        using (var transaction = connection.BeginTransaction())
                        {
                            using (var command = connection.CreateInsertCommand(_fixture.TableName))
                            {
                                command.Parameters.Add("Key", SpannerDbType.String, key);
                                command.Parameters.Add("UpdateMe", SpannerDbType.Bool, true);
                                command.Parameters.Add("DeleteMe", SpannerDbType.Bool, false);
                                command.Parameters.Add("CopyMe", SpannerDbType.Bool, false);

                                var originalValueParameter = command.Parameters.Add("OriginalValue", SpannerDbType.Int64);
                                var valueParameter = command.Parameters.Add("Value", SpannerDbType.Int64);

                                for (int j = 0; j < rowsPerInsertBatch; j++)
                                {
                                    originalValueParameter.Value = row;
                                    valueParameter.Value = row;
                                    command.ExecuteNonQuery();
                                    row++;
                                }
                            }
                            transaction.Commit();
                        }
                    }
                });
            }

            using (var connection = _fixture.GetConnection())
            {
                // Perform the update
                RetryHelpers.ExecuteWithRetry(() =>
                {
                    string dml = $"UPDATE {table} SET {table}.Value = {table}.OriginalValue + @amountToAdd WHERE {table}.UpdateMe AND {table}.Key=@key";
                    using (var command = connection.CreateDmlCommand(dml))
                    {
                        command.Parameters.Add("key", SpannerDbType.String, key);
                        command.Parameters.Add("amountToAdd", SpannerDbType.Int64, amountToAdd);
                        Assert.Equal(totalRows, command.ExecutePartitionedUpdate());
                    }
                });

                // Check results via query counts rather than fetching all values.
                using (var command = connection.CreateSelectCommand($"SELECT COUNT(1) FROM {table} WHERE Value >= @cutoff AND Key=@key"))
                {
                    command.Parameters.Add("key", SpannerDbType.String, key);
                    command.Parameters.Add("cutoff", SpannerDbType.Int64, amountToAdd);
                    Assert.Equal(totalRows, (long) command.ExecuteScalar());
                }

                using (var command = connection.CreateSelectCommand($"SELECT COUNT(1) FROM {table} WHERE Value < @cutoff AND Key=@key"))
                {
                    command.Parameters.Add("key", SpannerDbType.String, key);
                    command.Parameters.Add("cutoff", SpannerDbType.Int64, amountToAdd);
                    Assert.Equal(0, (long) command.ExecuteScalar());
                }
            }
        }

        // With DML's return clause ExecuteReaderAsync should return a reader containing affected rows data.
        [Theory, CombinatorialData]
        [Trait(Constants.SupportedOnEmulator, Constants.No)]
        public async Task DMLReturn_ExecuteReader_Read(TransactionType transactionType)
        {
            string key = _fixture.CreateTestRows();
            using var connection = _fixture.GetConnection();
            await connection.OpenAsync();
            string dml = $"UPDATE {_fixture.TableName} SET Value = OriginalValue + 1 WHERE UpdateMe AND Key=@key Then Return Value";
            var command = connection.CreateDmlCommand(dml);
            command.Parameters.Add("key", SpannerDbType.String, key);

            List<int> actualReturnedValues = await Execute(DmlAsyncWork, connection, transactionType);

            // Assert that the DML Return command has returned expected values only.
            var expectedReturnedValues = new List<int> { 2, 5 };
            Assert.Equal(expectedReturnedValues, actualReturnedValues);

            // Assert that the DML Return command has actually updated the table.
            AssertActualAndUpdatedDbValues(key);

            async Task<List<int>> DmlAsyncWork(SpannerTransaction transaction = null)
            {
                var returnedValues = new List<int>();
                command.Transaction = transaction;
                using var reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    returnedValues.Add(reader.GetFieldValue<int>(reader.GetOrdinal("Value")));
                }
                return returnedValues;
            }
        }

        // With DML's return clause ExecuteReaderAsync should update table data even if Read is not invoked.
        [Theory, CombinatorialData]
        [Trait(Constants.SupportedOnEmulator, Constants.No)]
        public async Task DMLReturn_ExecuteReader_NoRead(TransactionType transactionType)
        {
            string key = _fixture.CreateTestRows();

            using var connection = _fixture.GetConnection();
            await connection.OpenAsync();
            string dml = $"UPDATE {_fixture.TableName} SET Value = OriginalValue + 1 WHERE UpdateMe AND Key=@key Then Return Value";
            var command = connection.CreateDmlCommand(dml);
            command.Parameters.Add("key", SpannerDbType.String, key);

            _ = await Execute(DmlAsyncWork, connection, transactionType);

            AssertActualAndUpdatedDbValues(key);

            async Task<bool> DmlAsyncWork(SpannerTransaction transaction = null)
            {
                command.Transaction = transaction;
                var reader = await command.ExecuteReaderAsync();
                return true;
            }
        }

        // With DML's return clause ExecuteNonQueryAsync should return number of affected rows.
        [Theory, CombinatorialData]
        [Trait(Constants.SupportedOnEmulator, Constants.No)]
        public async Task DMLReturn_ExecuteNonQueryAsync(TransactionType transactionType)
        {
            string key = _fixture.CreateTestRows();
            using var connection = _fixture.GetConnection();
            string dml = $"UPDATE {_fixture.TableName} SET Value = OriginalValue + 1 WHERE UpdateMe AND Key=@key Then Return Value";
            using var command = connection.CreateDmlCommand(dml);
            command.Parameters.Add("key", SpannerDbType.String, key);

            int actualAffectedRows = await Execute(DmlAsyncWork, connection, transactionType);

            Assert.Equal(2, actualAffectedRows);
            AssertActualAndUpdatedDbValues(key);

            async Task<int> DmlAsyncWork(SpannerTransaction transaction = null)
            {
                command.Transaction = transaction;
                return await command.ExecuteNonQueryAsync();
            }
        }

        // Without DML's return clause also ExecuteReaderAsync should update the database table.
        // First ReadAsync call should return false in the absence of 'return` clause.
        [Theory, CombinatorialData]
        public async Task NoDMLReturn_ExecuteReader_Read(TransactionType transactionType)
        {
            string key = _fixture.CreateTestRows();

            using var connection = _fixture.GetConnection();
            await connection.OpenAsync();
            string dml = $"UPDATE {_fixture.TableName} SET Value = OriginalValue + 1 WHERE UpdateMe AND Key=@key";
            var command = connection.CreateDmlCommand(dml);
            command.Parameters.Add("key", SpannerDbType.String, key);

            bool read = await Execute(DmlAsyncWork, connection, transactionType);

            Assert.False(read);
            AssertActualAndUpdatedDbValues(key);

            async Task<bool> DmlAsyncWork(SpannerTransaction transaction = null)
            {
                command.Transaction = transaction;
                using var reader = await command.ExecuteReaderAsync();
                var readOnce = await reader.ReadAsync();
                return readOnce;
            }
        }

        // ExecuteReaderAsync still updates the database, even if we don't read from the returned reader and don't include "Then Return".
        [Theory, CombinatorialData]
        public async Task NoDMLReturn_ExecuteReader_NoRead(TransactionType transactionType)
        {
            string key = _fixture.CreateTestRows();
            using var connection = _fixture.GetConnection();
            await connection.OpenAsync();
            string dml = $"UPDATE {_fixture.TableName} SET Value = OriginalValue + 1 WHERE UpdateMe AND Key=@key";
            var command = connection.CreateDmlCommand(dml);
            command.Parameters.Add("key", SpannerDbType.String, key);

            await Execute(DmlAsyncWork, connection, transactionType);

            AssertActualAndUpdatedDbValues(key);

            async Task<List<int>> DmlAsyncWork(SpannerTransaction transaction = null)
            {
                command.Transaction = transaction;
                var reader = await command.ExecuteReaderAsync();
                return null;
            }
        }

        private async Task<T> Execute<T>(Func<SpannerTransaction, Task<T>> dmlAsyncWork, SpannerConnection connection, TransactionType transactionType)
        {
            switch (transactionType)
            {
                case TransactionType.EphemeralTransaction:
                    return await dmlAsyncWork(null);
                case TransactionType.ExplicitTransaction:
                    {
                        using var transaction = connection.BeginTransaction();
                        var result = await dmlAsyncWork(transaction).ConfigureAwait(false);
                        transaction.Commit();
                        return result;
                    }
                case TransactionType.RetryableTransaction:
                    return await connection.RunWithRetriableTransactionAsync(dmlAsyncWork);
                default:
                    throw new ArgumentException($"Invalid argument '{transactionType}'.");
            }
        }

        private void AssertActualAndUpdatedDbValues(string key, SpannerTransaction transaction = null)
        {
            var actualDbValues = _fixture.FetchValues(key, transaction);
            var expectedDbValues = new Dictionary<int, int>
            {
                { 0, 0 }, // Not updated
                { 1, 2 }, // Updated
                { 2, 2 }, // Not updated
                { 3, 3 }, // Not updated
                { 4, 5 }  // Updated
            };

            Assert.Equal(expectedDbValues, actualDbValues);
        }
    }
}
