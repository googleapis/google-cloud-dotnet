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
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [Collection(nameof(DmlTableFixture))]
    public class BatchDmlTests
    {
        private readonly DmlTableFixture _fixture;

        public BatchDmlTests(DmlTableFixture fixture) => _fixture = fixture;

        [Fact]
        public void ValidBatchDml()
        {
            string key = _fixture.CreateTestRows();

            IEnumerable<long> affectedRows = null;
            using (var connection = _fixture.GetConnection())
            {
                RetryHelpers.ExecuteWithRetry(() =>
                {
                    var command = connection.CreateBatchDmlCommand();

                    command.Add(
                        $"INSERT INTO {_fixture.TableName} (Key, OriginalValue, Value, UpdateMe, DeleteMe, CopyMe) SELECT Key, OriginalValue + 10, Value, UpdateMe, DeleteMe, CopyMe FROM {_fixture.TableName} WHERE CopyMe AND KEY=@Key",
                        new SpannerParameterCollection { { "Key", SpannerDbType.String, key } });

                    command.Add(
                        $"UPDATE {_fixture.TableName} SET Value = OriginalValue + 1 WHERE UpdateMe AND Key=@key",
                        new SpannerParameterCollection { { "Key", SpannerDbType.String, key } });

                    command.Add(
                        $"DELETE FROM {_fixture.TableName} WHERE DeleteMe AND Key=@key",
                        new SpannerParameterCollection { { "Key", SpannerDbType.String, key } });

                    affectedRows = command.ExecuteNonQuery();
                });
            }

            Assert.NotNull(affectedRows);
            var expectedAffectedRows = new long[] { 2, 3, 3 };
            Assert.Equal(expectedAffectedRows, affectedRows);

            var actual = _fixture.FetchValues(key);
            var expected = new Dictionary<int, int>
            {
                { 0, 0 },
                { 1, 2 }, // Updated
                // { 2, 2 }, Deleted
                { 3, 3 },
                // { 4, 5 }, Updated then deleted
                { 13, 3 }, // Copied
                // { 14, 5 } Copied then updated then deleted
            };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidBatchDml_ValidUpdateDml()
        {
            string key = _fixture.CreateTestRows();

            IEnumerable<long> batchAffectedRows = null;
            int dmlAffectedRows = 0;
            using (var connection = _fixture.GetConnection())
            {
                using (var transaction = connection.BeginTransaction())
                {
                    RetryHelpers.ExecuteWithRetry(() =>
                    {
                        var batchCommand = transaction.CreateBatchDmlCommand();

                        batchCommand.Add(
                            $"INSERT INTO {_fixture.TableName} (Key, OriginalValue, Value, UpdateMe, DeleteMe, CopyMe) SELECT Key, OriginalValue + 10, Value, UpdateMe, DeleteMe, CopyMe FROM {_fixture.TableName} WHERE CopyMe AND KEY=@Key",
                            new SpannerParameterCollection { { "Key", SpannerDbType.String, key } });

                        batchCommand.Add(
                            $"UPDATE {_fixture.TableName} SET Value = OriginalValue + 1 WHERE UpdateMe AND Key=@key",
                            new SpannerParameterCollection { { "Key", SpannerDbType.String, key } });

                        batchCommand.Add(
                            $"DELETE FROM {_fixture.TableName} WHERE DeleteMe AND Key=@key",
                            new SpannerParameterCollection { { "Key", SpannerDbType.String, key } });

                        batchAffectedRows = batchCommand.ExecuteNonQuery();
                    });

                    RetryHelpers.ExecuteWithRetry(() =>
                    {
                        var dmlCommand = connection.CreateDmlCommand(
                            $"UPDATE {_fixture.TableName} SET Value = Value + 2 WHERE UpdateMe AND Key=@key",
                            new SpannerParameterCollection { { "Key", SpannerDbType.String, key } });
                        dmlCommand.Transaction = transaction;

                        dmlAffectedRows = dmlCommand.ExecuteNonQuery();
                    });

                    transaction.Commit();
                }
            }

            Assert.NotNull(batchAffectedRows);
            var expectedBatchAffectedRows = new long[] { 2, 3, 3 };
            Assert.Equal(expectedBatchAffectedRows, batchAffectedRows);

            int expectedDmlAffectedRows = 1;
            Assert.Equal(expectedDmlAffectedRows, dmlAffectedRows);

            var actual = _fixture.FetchValues(key);
            var expected = new Dictionary<int, int>
            {
                { 0, 0 },
                { 1, 4 }, // Updated by batch, updated by dml.
                // { 2, 2 }, Deleted
                { 3, 3 },
                // { 4, 5 }, Updated then deleted
                { 13, 3 }, // Copied
                // { 14, 5 } Copied then updated then deleted
            };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InvalidDmlBatch_FailsClientSide()
        {
            string key = _fixture.CreateTestRows();

            using (var connection = _fixture.GetConnection())
            {
                var command = connection.CreateBatchDmlCommand();

                command.Add(
                    $"INSERT INTO {_fixture.TableName} (Key, OriginalValue, Value, UpdateMe, DeleteMe, CopyMe) SELECT Key, OriginalValue + 10, Value, UpdateMe, DeleteMe, CopyMe FROM {_fixture.TableName} WHERE CopyMe AND KEY=@Key",
                    new SpannerParameterCollection { { "Key", SpannerDbType.String, key } });

                // This is not a valid DML command.
                Assert.Throws<InvalidOperationException>(() =>
                command.Add(
                    $"DELETE {_fixture.TableName}",
                    new SpannerParameterCollection
                    {
                        { "Key", SpannerDbType.String, key },
                        { "OriginalValue", SpannerDbType.Int64, 2 }
                    }));
            }
        }

        [Fact]
        public void InvalidConnection_ThrowsSpannerException()
        {
            string key = _fixture.CreateTestRows();

            SpannerException exception = null;

            var connectionString = _fixture.ConnectionString;
            var connectionBuilder = new SpannerConnectionStringBuilder(connectionString);
            connectionBuilder = connectionBuilder.WithDatabase("dummy-database-name");

            using (var connection = new SpannerConnection(connectionBuilder))
            {
                var command = connection.CreateBatchDmlCommand();

                command.Add(
                    $"UPDATE {_fixture.TableName} SET Value = OriginalValue + 1 WHERE UpdateMe AND Key=@key",
                    new SpannerParameterCollection { { "Key", SpannerDbType.String, key } });

                command.Add(
                    $"DELETE FROM {_fixture.TableName} WHERE DeleteMe AND Key=@key",
                    new SpannerParameterCollection { { "Key", SpannerDbType.String, key } });

                command.Add(
                    "DELETE FROM inexistentTable WHERE DeleteMe AND Key=@key",
                    new SpannerParameterCollection { { "Key", SpannerDbType.String, key } });

                // Throws SpannerException and not SpannerBatchNonQueryException
                exception = Assert.Throws<SpannerException>(command.ExecuteNonQuery);
            }

            var actual = _fixture.FetchValues(key);
            var expected = new Dictionary<int, int>
            {
                { 0, 0 },
                { 1, 1 },
                { 2, 2 },
                { 3, 3 },
                { 4, 4 },
            };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InvalidDmlBatch_PartialSuccess_ExplicitTransaction()
        {
            string key = _fixture.CreateTestRows();

            using (var connection = _fixture.GetConnection())
            {
                using (var transaction = connection.BeginTransaction())
                {
                    var command = transaction.CreateBatchDmlCommand();

                    command.Add(
                        $"UPDATE {_fixture.TableName} SET Value = OriginalValue + 1 WHERE UpdateMe AND Key=@key",
                        new SpannerParameterCollection { { "Key", SpannerDbType.String, key } });

                    command.Add(
                        $"DELETE FROM {_fixture.TableName} WHERE DeleteMe AND Key=@key",
                        new SpannerParameterCollection { { "Key", SpannerDbType.String, key } });

                    command.Add(
                        "DELETE FROM inexistentTable WHERE DeleteMe AND Key=@key",
                        new SpannerParameterCollection { { "Key", SpannerDbType.String, key } });

                    var exception = Assert.Throws<SpannerBatchNonQueryException>(command.ExecuteNonQuery);

                    IEnumerable<long> affectedRows = exception.SuccessfulCommandResults;
                    Assert.NotNull(affectedRows);
                    var expectedAffectedRows = new long[] { 2, 2 };
                    Assert.Equal(expectedAffectedRows, affectedRows);

                    // We haven't yet rollbacked the transaction so the changes from the first two statements
                    // should be visible

                    var actualInTransactionScope = _fixture.FetchValues(key, transaction);
                    var expectedInTransactionScope = new Dictionary<int, int>
                    {
                        { 0, 0 },
                        { 1, 2 }, // Updated
                        // { 2, 2 }, Deleted
                        { 3, 3 },
                        // { 4, 5 }, Updated then deleted
                    };
                    Assert.Equal(expectedInTransactionScope, actualInTransactionScope);

                    transaction.Rollback();
                }
            }

            // After transaction rollback no changes to the data should be seen.
            var actual = _fixture.FetchValues(key);
            var expected = new Dictionary<int, int>
            {
                { 0, 0 },
                { 1, 1 },
                { 2, 2 },
                { 3, 3 },
                { 4, 4 },
            };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InvalidDmlBatch_PartialSuccess_ImplicitTransaction()
        {
            string key = _fixture.CreateTestRows();

            SpannerBatchNonQueryException exception;
            using (var connection = _fixture.GetConnection())
            {
                var command = connection.CreateBatchDmlCommand();

                command.Add(
                    $"UPDATE {_fixture.TableName} SET Value = OriginalValue + 1 WHERE UpdateMe AND Key=@key",
                    new SpannerParameterCollection { { "Key", SpannerDbType.String, key } });

                command.Add(
                    $"DELETE FROM {_fixture.TableName} WHERE DeleteMe AND Key=@key",
                    new SpannerParameterCollection { { "Key", SpannerDbType.String, key } });

                command.Add(
                    "DELETE FROM inexistentTable WHERE DeleteMe AND Key=@key",
                    new SpannerParameterCollection { { "Key", SpannerDbType.String, key } });

                // Since this is a batch DML command, for which partial success is not valid,
                // the implicit transaction is rollbacked even when some of the commands executed sucesfully.
                // Changes made by te command should not be visible to anyone.
                exception = Assert.Throws<SpannerBatchNonQueryException>(command.ExecuteNonQuery);
            }

            // But the exception will contain the number of affected rows by the succesful commands.
            IEnumerable<long> affectedRows = exception.SuccessfulCommandResults;
            Assert.NotNull(affectedRows);
            var expectedAffectedRows = new long[] { 2, 2 };
            Assert.Equal(expectedAffectedRows, affectedRows);

            var actual = _fixture.FetchValues(key);
            var expected = new Dictionary<int, int>
                {
                    { 0, 0 },
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                };
            Assert.Equal(expected, actual);
        }
    }
}
