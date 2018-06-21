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
using System.Runtime.CompilerServices;
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

        public DmlTests(DmlTableFixture fixture) => _fixture = fixture;

        /// <summary>
        /// Each test is able to use a different set of rows, varied by key value K.
        /// This method creates the rows with a random K and returns K.
        /// </summary>
        private string CreateTestRows([CallerMemberName] string testName = null)
        {
            string key = $"{testName} - {Guid.NewGuid()}";
            Insert(0, false, false, false);
            Insert(1, true, false, false);
            Insert(2, false, true, false);
            Insert(3, false, false, true);
            Insert(4, true, true, true);

            void Insert(int value, bool update, bool delete, bool copy)
            {
                RetryHelpers.RetryOnce(() =>
                {
                    using (var connection = _fixture.GetConnection())
                    {
                        using (var command = connection.CreateInsertCommand(_fixture.TableName))
                        {
                            command.Parameters.Add("Key", SpannerDbType.String, key);
                            command.Parameters.Add("OriginalValue", SpannerDbType.Int64, value);
                            command.Parameters.Add("Value", SpannerDbType.Int64, value);
                            command.Parameters.Add("UpdateMe", SpannerDbType.Bool, update);
                            command.Parameters.Add("DeleteMe", SpannerDbType.Bool, delete);
                            command.Parameters.Add("CopyMe", SpannerDbType.Bool, copy);
                            RetryHelpers.RetryOnce(() => command.ExecuteNonQuery());
                        }
                    }
                });
            }
            return key;
        }

        [Fact]
        public void Update()
        {
            string key = CreateTestRows();
            using (var connection = _fixture.GetConnection())
            {
                RetryHelpers.RetryOnce(() =>
                {
                    string dml = $"UPDATE {_fixture.TableName} SET Value = OriginalValue + 1 WHERE UpdateMe AND Key=@key";
                    using (var command = connection.CreateDmlCommand(dml))
                    {
                        command.Parameters.Add("key", SpannerDbType.String, key);
                        Assert.Equal(2, command.ExecuteNonQuery());
                    }
                });
            }
            var actual = FetchValues(key);
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
            string key = CreateTestRows();
            using (var connection = _fixture.GetConnection())
            {
                await RetryHelpers.RetryOnceAsync(async () =>
                {
                    string dml = $"UPDATE {_fixture.TableName} SET Value = OriginalValue + 1 WHERE UpdateMe AND Key=@key";
                    using (var command = connection.CreateDmlCommand(dml))
                    {
                        command.Parameters.Add("key", SpannerDbType.String, key);
                        Assert.Equal(2, await command.ExecuteNonQueryAsync());
                    }
                });
            }
            var actual = FetchValues(key);
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
            string key = CreateTestRows();
            using (var connection = _fixture.GetConnection())
            {
                RetryHelpers.RetryOnce(() =>
                {
                    string dml = $"DELETE FROM {_fixture.TableName} WHERE DeleteMe AND Key=@key";
                    using (var command = connection.CreateDmlCommand(dml))
                    {
                        command.Parameters.Add("key", SpannerDbType.String, key);
                        Assert.Equal(2, command.ExecuteNonQuery());
                    }
                });
            }
            var actual = FetchValues(key);
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
            string key = CreateTestRows();
            using (var connection = _fixture.GetConnection())
            {
                RetryHelpers.RetryOnce(() =>
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
            var actual = FetchValues(key);
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
            string key = CreateTestRows();
            using (var connection = _fixture.GetConnection())
            {
                RetryHelpers.RetryOnce(() =>
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
            var actual = FetchValues(key);
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
            string key = CreateTestRows();
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
            string key = CreateTestRows();
            using (var connection = _fixture.GetConnection())
            {
                string dml = $"DELETE FROM {_fixture.TableName} WHERE DeleteMe AND Key=@key";
                using (var command = connection.CreateDmlCommand(dml))
                {
                    command.Parameters.Add("key", SpannerDbType.String, key);
                    Assert.Throws<InvalidOperationException>(() => command.ExecuteReader());
                    Assert.Throws<InvalidOperationException>(() => command.ExecuteScalar());
                }
            }
        }

        [Fact]
        public void ReadOnlyTransaction_Invalid()
        {
            string key = CreateTestRows();
            using (var connection = _fixture.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginReadOnlyTransaction())
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
            string key = CreateTestRows();
            using (var connection = _fixture.GetConnection())
            {
                connection.Open();
                RetryHelpers.RetryOnce(() =>
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
            var actual = FetchValues(key);
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
        public void DmlResultsVisibleWithinTransaction()
        {
            string key = CreateTestRows();
            Dictionary<int, int> fetchedWithinTransaction = null;
            using (var connection = _fixture.GetConnection())
            {
                connection.Open();
                RetryHelpers.RetryOnce(() =>
                {
                    using (var transaction = connection.BeginTransaction())
                    {
                        string dml = $"UPDATE {_fixture.TableName} SET Value = OriginalValue + 1 WHERE UpdateMe AND Key=@key";
                        using (var command = connection.CreateDmlCommand(dml))
                        {
                            command.Transaction = transaction;
                            command.Parameters.Add("key", SpannerDbType.String, key);
                            Assert.Equal(2, command.ExecuteNonQuery());
                            fetchedWithinTransaction = FetchValues(key, transaction);
                            transaction.Commit();
                        }
                    }
                });
            }
            var fetchedAfterTransaction = FetchValues(key);
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
            string key = CreateTestRows();
            using (var connection = _fixture.GetConnection())
            {
                connection.Open();
                RetryHelpers.RetryOnce(() =>
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
            var actual = FetchValues(key);
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
            string key = CreateTestRows();
            using (var connection = _fixture.GetConnection())
            {
                connection.Open();
                string dml = $"INSERT INTO {_fixture.TableName} (Key, OriginalValue, Value) VALUES (@key, @ov1, @v1)";
                RetryHelpers.RetryOnce(() =>
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
            var actual = FetchValues(key);
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
        public void PartitionedUpdate()
        {
            string key = CreateTestRows();
            string table = _fixture.TableName;
            using (var connection = _fixture.GetConnection())
            {
                RetryHelpers.RetryOnce(() =>
                {
                    string dml = $"UPDATE {table} SET {table}.Value = {table}.OriginalValue + 1 WHERE {table}.UpdateMe AND {table}.Key=@key";
                    using (var command = connection.CreateDmlCommand(dml))
                    {
                        command.Parameters.Add("key", SpannerDbType.String, key);
                        Assert.Equal(2L, command.ExecutePartitionedUpdate());
                    }
                });
            }
            var actual = FetchValues(key);
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

        // Further tests:
        // - Simple PDML
        // - Longrunning PDML (skipped by default)

        private Dictionary<int, int> FetchValues(string key, SpannerTransaction transaction = null)
        {
            using (var connection = _fixture.GetConnection())
            {
                using (var command = connection.CreateSelectCommand($"SELECT OriginalValue, Value FROM {_fixture.TableName} WHERE Key=@key"))
                {
                    if (transaction != null)
                    {
                        command.Transaction = transaction;
                    }
                    command.Parameters.Add("key", SpannerDbType.String, key);
                    using (var reader = command.ExecuteReader())
                    {
                        var dictionary = new Dictionary<int, int>();
                        while (reader.Read())
                        {
                            dictionary.Add(reader.GetInt32(0), reader.GetInt32(1));
                        }
                        return dictionary;
                    }
                }
            }
        }
    }
}
