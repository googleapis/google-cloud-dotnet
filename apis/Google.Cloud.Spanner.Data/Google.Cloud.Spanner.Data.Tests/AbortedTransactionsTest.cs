// Copyright 2020 Google LLC
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

using Google.Protobuf;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests
{
    public class AbortedTransactionsTests : IClassFixture<SpannerMockServerFixture>
    {
        SpannerMockServerFixture _fixture;

        public AbortedTransactionsTests(SpannerMockServerFixture service)
        {
            this._fixture = service;
        }

        [Fact]
        public async void ReadWriteTransaction_AbortedDml_IsAutomaticallyRetried()
        {
            string sql = "UPDATE Foo SET Bar='bar' WHERE Id=1";
            _fixture.SpannerMock.AddOrUpdateStatementResult(sql, StatementResult.CreateUpdateCount(1));
            string connectionString = $"Data Source=projects/p1/instances/i1/databases/d1;Host={_fixture.Host};Port={_fixture.Port}";
            using (var connection = new SpannerConnection(connectionString, ChannelCredentials.Insecure))
            {
                await connection.OpenAsync();
                using (var transaction = await connection.BeginRetriableTransactionAsync())
                {
                    var originalTxId = transaction.TransactionId;
                    // Abort the transaction on the mock server. The transaction should be able to internally retry.
                    _fixture.SpannerMock.AbortTransaction(ByteString.FromBase64(transaction.TransactionId.Id));
                    var cmd = connection.CreateDmlCommand(sql);
                    cmd.Transaction = transaction;
                    var updateCount = await cmd.ExecuteNonQueryAsync();
                    Assert.NotEqual(originalTxId.Id, transaction.TransactionId.Id);
                    await transaction.CommitAsync();
                    Assert.Equal(1, updateCount);
                    Assert.Equal(1, transaction.RetryCount);
                }
            }
        }

        [Fact]
        public async void ReadWriteTransaction_ModifiedDmlUpdateCount_FailsRetry()
        {
            // This statement returns an update count of 1 the first time.
            string sql = "UPDATE Foo SET Bar='baz' WHERE Id IN (1,2)";
            _fixture.SpannerMock.AddOrUpdateStatementResult(sql, StatementResult.CreateUpdateCount(1));

            string connectionString = $"Data Source=projects/p1/instances/i1/databases/d1;Host={_fixture.Host};Port={_fixture.Port}";
            using (var connection = new SpannerConnection(connectionString, ChannelCredentials.Insecure))
            {
                await connection.OpenAsync();
                using (var transaction = await connection.BeginRetriableTransactionAsync())
                {
                    // Execute an update and then change the return value for the statement before the retry is executed.
                    var cmd = connection.CreateDmlCommand(sql);
                    cmd.Transaction = transaction;
                    Assert.Equal(1, await cmd.ExecuteNonQueryAsync());
                    // The update statement will return 2 the next time it is executed.
                    _fixture.SpannerMock.AddOrUpdateStatementResult(sql, StatementResult.CreateUpdateCount(2));

                    // Now abort the transaction and try to execute another DML statement. The retry will fail because it sees
                    // a different update count during the retry.
                    _fixture.SpannerMock.AbortTransaction(ByteString.FromBase64(transaction.TransactionId.Id));
                    cmd = connection.CreateDmlCommand("UPDATE Foo SET Bar='bar' WHERE Id=1");
                    cmd.Transaction = transaction;
                    try
                    {
                        await cmd.ExecuteNonQueryAsync();
                        Assert.True(false, "Missing expected exception");
                    }
                    catch (SpannerAbortedDueToConcurrentModificationException)
                    {
                        Assert.Equal(1, transaction.RetryCount);
                    }
                }
            }
        }

        [Fact]
        public async void ReadWriteTransaction_AbortedDmlWithSameException_CanBeRetried()
        {
            string sql = "UPDATE Foo SET Bar='bar'";
            _fixture.SpannerMock.AddOrUpdateStatementResult(sql, StatementResult.CreateException(new RpcException(new Status(StatusCode.FailedPrecondition, "UPDATE statement misses WHERE clause"))));
            string connectionString = $"Data Source=projects/p1/instances/i1/databases/d1;Host={_fixture.Host};Port={_fixture.Port}";
            using (var connection = new SpannerConnection(connectionString, ChannelCredentials.Insecure))
            {
                await connection.OpenAsync();
                using (var transaction = await connection.BeginRetriableTransactionAsync())
                {
                    var cmd = connection.CreateDmlCommand(sql);
                    cmd.Transaction = transaction;
                    try
                    {
                        await cmd.ExecuteNonQueryAsync();
                        Assert.True(false, "Missing expected exception");
                    }
                    catch (SpannerException e) when (e.ErrorCode == ErrorCode.FailedPrecondition)
                    {
                        Assert.Contains("UPDATE statement misses WHERE clause", e.InnerException?.Message);
                    }
                    // Abort the transaction on the mock server. The transaction should be able to internally retry.
                    _fixture.SpannerMock.AbortTransaction(ByteString.FromBase64(transaction.TransactionId.Id));
                    await transaction.CommitAsync();
                    Assert.Equal(1, transaction.RetryCount);
                }
            }
        }

        [Fact]
        public async void ReadWriteTransaction_AbortedDmlWithDifferentException_FailsRetry()
        {
            string sql = "UPDATE Foo SET Bar='bar' WHERE Id=1";
            _fixture.SpannerMock.AddOrUpdateStatementResult(sql, StatementResult.CreateException(new RpcException(new Status(StatusCode.AlreadyExists, "Unique key constraint violation"))));
            string connectionString = $"Data Source=projects/p1/instances/i1/databases/d1;Host={_fixture.Host};Port={_fixture.Port}";
            using (var connection = new SpannerConnection(connectionString, ChannelCredentials.Insecure))
            {
                await connection.OpenAsync();
                using (var transaction = await connection.BeginRetriableTransactionAsync())
                {
                    var cmd = connection.CreateDmlCommand(sql);
                    cmd.Transaction = transaction;
                    try
                    {
                        await cmd.ExecuteNonQueryAsync();
                        Assert.True(false, "Missing expected exception");
                    }
                    catch (SpannerException e) when (e.ErrorCode == ErrorCode.AlreadyExists)
                    {
                        Assert.Contains("Unique key constraint violation", e.InnerException?.Message);
                    }
                    // Change the error for the statement on the mock server and abort the transaction.
                    // The retry should now fail as the error has changed.
                    _fixture.SpannerMock.AddOrUpdateStatementResult(sql, StatementResult.CreateException(new RpcException(new Status(StatusCode.NotFound, "Table Foo not found"))));
                    _fixture.SpannerMock.AbortTransaction(ByteString.FromBase64(transaction.TransactionId.Id));
                    try
                    {
                        await transaction.CommitAsync();
                        Assert.True(false, "Missing expected exception");
                    }
                    catch (SpannerAbortedDueToConcurrentModificationException)
                    {
                        Assert.Equal(1, transaction.RetryCount);
                    }
                }
            }
        }

        [Fact]
        public async void ReadWriteTransaction_AbortedBatchDml_IsAutomaticallyRetried()
        {
            string sql1 = "UPDATE Foo SET Bar='bar' WHERE Id=1";
            string sql2 = "UPDATE Foo SET Bar='baz' WHERE Id IN (2,3)";
            _fixture.SpannerMock.AddOrUpdateStatementResult(sql1, StatementResult.CreateUpdateCount(1));
            _fixture.SpannerMock.AddOrUpdateStatementResult(sql2, StatementResult.CreateUpdateCount(2));
            string connectionString = $"Data Source=projects/p1/instances/i1/databases/d1;Host={_fixture.Host};Port={_fixture.Port}";
            using (var connection = new SpannerConnection(connectionString, ChannelCredentials.Insecure))
            {
                await connection.OpenAsync();
                using (var transaction = await connection.BeginRetriableTransactionAsync())
                {
                    var originalTxId = transaction.TransactionId;
                    // Abort the transaction on the mock server. The transaction should be able to internally retry.
                    _fixture.SpannerMock.AbortTransaction(ByteString.FromBase64(transaction.TransactionId.Id));
                    var cmd = transaction.CreateBatchDmlCommand();
                    cmd.Add(sql1);
                    cmd.Add(sql2);
                    var updateCounts = await cmd.ExecuteNonQueryAsync();
                    Assert.NotEqual(originalTxId.Id, transaction.TransactionId.Id);
                    await transaction.CommitAsync();
                    Assert.Equal(new List<long> { 1, 2 }, updateCounts);
                    Assert.Equal(1, transaction.RetryCount);
                }
            }
        }

        [Fact]
        public async void ReadWriteTransaction_ModifiedBatchDmlUpdateCount_FailsRetry()
        {
            string sql1 = "UPDATE Foo SET Bar='bar' WHERE Id=1";
            string sql2 = "UPDATE Foo SET Bar='baz' WHERE Id IN (2,3)";
            _fixture.SpannerMock.AddOrUpdateStatementResult(sql1, StatementResult.CreateUpdateCount(1));
            _fixture.SpannerMock.AddOrUpdateStatementResult(sql2, StatementResult.CreateUpdateCount(2));
            string connectionString = $"Data Source=projects/p1/instances/i1/databases/d1;Host={_fixture.Host};Port={_fixture.Port}";
            using (var connection = new SpannerConnection(connectionString, ChannelCredentials.Insecure))
            {
                await connection.OpenAsync();
                using (var transaction = await connection.BeginRetriableTransactionAsync())
                {
                    var cmd = transaction.CreateBatchDmlCommand();
                    cmd.Add(sql1);
                    cmd.Add(sql2);
                    Assert.Equal(new List<long> { 1, 2 }, await cmd.ExecuteNonQueryAsync());
                    // Change the update count returned by one of the statements and abort the transaction.
                    _fixture.SpannerMock.AddOrUpdateStatementResult(sql2, StatementResult.CreateUpdateCount(1));
                    _fixture.SpannerMock.AbortTransaction(ByteString.FromBase64(transaction.TransactionId.Id));

                    try
                    {
                        await transaction.CommitAsync();
                        Assert.True(false, "Missing expected exception");
                    }
                    catch (SpannerAbortedDueToConcurrentModificationException)
                    {
                        Assert.Equal(1, transaction.RetryCount);
                    }
                }
            }
        }

        [Fact]
        public async void ReadWriteTransaction_BatchDmlWithSameException_CanBeRetried()
        {
            // UPDATE statement that misses a WHERE clause.
            string sql1 = "UPDATE Foo SET Bar='bar'";
            _fixture.SpannerMock.AddOrUpdateStatementResult(sql1, StatementResult.CreateException(new RpcException(new Status(StatusCode.FailedPrecondition, "UPDATE statement misses WHERE clause"))));
            string connectionString = $"Data Source=projects/p1/instances/i1/databases/d1;Host={_fixture.Host};Port={_fixture.Port}";
            using (var connection = new SpannerConnection(connectionString, ChannelCredentials.Insecure))
            {
                await connection.OpenAsync();
                using (var transaction = await connection.BeginRetriableTransactionAsync())
                {
                    var cmd = transaction.CreateBatchDmlCommand();
                    cmd.Add(sql1);
                    try
                    {
                        await cmd.ExecuteNonQueryAsync();
                        Assert.True(false, "Missing expected exception");
                    }
                    catch (SpannerException e) when (e.ErrorCode == ErrorCode.FailedPrecondition)
                    {
                        Assert.Contains("UPDATE statement misses WHERE clause", e.InnerException?.Message);
                    }
                    // Abort the transaction and try to commit. That will trigger a retry, and the retry will receive
                    // the same error for the BatchDML call as the original attempt.
                    _fixture.SpannerMock.AbortTransaction(ByteString.FromBase64(transaction.TransactionId.Id));
                    await transaction.CommitAsync();
                    Assert.Equal(1, transaction.RetryCount);
                }
            }
        }

        [Fact]
        public async void ReadWriteTransaction_BatchDmlWithDifferentException_FailsRetry()
        {
            string sql1 = "UPDATE Foo SET Bar='bar' WHERE Id=1";
            _fixture.SpannerMock.AddOrUpdateStatementResult(sql1, StatementResult.CreateException(new RpcException(new Status(StatusCode.AlreadyExists, "Unique key constraint violation"))));
            string connectionString = $"Data Source=projects/p1/instances/i1/databases/d1;Host={_fixture.Host};Port={_fixture.Port}";
            using (var connection = new SpannerConnection(connectionString, ChannelCredentials.Insecure))
            {
                await connection.OpenAsync();
                using (var transaction = await connection.BeginRetriableTransactionAsync())
                {
                    var cmd = transaction.CreateBatchDmlCommand();
                    cmd.Add(sql1);
                    try
                    {
                        await cmd.ExecuteNonQueryAsync();
                        Assert.True(false, "Missing expected exception");
                    }
                    catch (SpannerException e) when (e.ErrorCode == ErrorCode.AlreadyExists)
                    {
                        Assert.Contains("Unique key constraint violation", e.InnerException?.Message);
                    }

                    // Remove the error message for the udpate statement.
                    _fixture.SpannerMock.AddOrUpdateStatementResult(sql1, StatementResult.CreateUpdateCount(1));
                    // Abort the transaction and try to commit. That will trigger a retry, but the retry
                    // will not receive an error for the update statement. That will fail the retry.
                    _fixture.SpannerMock.AbortTransaction(ByteString.FromBase64(transaction.TransactionId.Id));
                    try
                    {
                        await transaction.CommitAsync();
                        Assert.True(false, "Missing expected exception");
                    }
                    catch (SpannerAbortedDueToConcurrentModificationException)
                    {
                        Assert.Equal(1, transaction.RetryCount);
                    }
                }
            }
        }

        [Fact]
        public async void ReadWriteTransaction_BatchDmlWithSameExceptionHalfwayAndSameResults_CanBeRetried()
        {
            string sql1 = "UPDATE Foo SET Bar='valid' WHERE Id=1";
            string sql2 = "UPDATE Foo SET Bar='invalid'";
            _fixture.SpannerMock.AddOrUpdateStatementResult(sql1, StatementResult.CreateUpdateCount(1));
            _fixture.SpannerMock.AddOrUpdateStatementResult(sql2, StatementResult.CreateException(new RpcException(new Status(StatusCode.FailedPrecondition, "UPDATE statement misses WHERE clause"))));
            string connectionString = $"Data Source=projects/p1/instances/i1/databases/d1;Host={_fixture.Host};Port={_fixture.Port}";
            using (var connection = new SpannerConnection(connectionString, ChannelCredentials.Insecure))
            {
                await connection.OpenAsync();
                using (var transaction = await connection.BeginRetriableTransactionAsync())
                {
                    var cmd = transaction.CreateBatchDmlCommand();
                    cmd.Add(sql1);
                    cmd.Add(sql2);
                    try
                    {
                        await cmd.ExecuteNonQueryAsync();
                        Assert.True(false, "Missing expected exception");
                    }
                    catch (SpannerBatchNonQueryException e)
                    {
                        Assert.Contains("UPDATE statement misses WHERE clause", e.Message);
                        Assert.Equal(new List<long> { 1 }, e.SuccessfulCommandResults);
                    }
                    // Abort the transaction and try to commit. That will trigger a retry, and the retry will receive
                    // the same error and the same results for the BatchDML call as the original attempt.
                    _fixture.SpannerMock.AbortTransaction(ByteString.FromBase64(transaction.TransactionId.Id));
                    await transaction.CommitAsync();
                    Assert.Equal(1, transaction.RetryCount);
                }
            }
        }

        [Fact]
        public async void ReadWriteTransaction_BatchDmlWithSameExceptionHalfwayAndDifferentResults_FailsRetry()
        {
            string sql1 = "UPDATE Foo SET Bar='valid' WHERE Id=1";
            string sql2 = "UPDATE Foo SET Bar='invalid'";
            _fixture.SpannerMock.AddOrUpdateStatementResult(sql1, StatementResult.CreateUpdateCount(1));
            _fixture.SpannerMock.AddOrUpdateStatementResult(sql2, StatementResult.CreateException(new RpcException(new Status(StatusCode.FailedPrecondition, "UPDATE statement misses WHERE clause"))));
            string connectionString = $"Data Source=projects/p1/instances/i1/databases/d1;Host={_fixture.Host};Port={_fixture.Port}";
            using (var connection = new SpannerConnection(connectionString, ChannelCredentials.Insecure))
            {
                await connection.OpenAsync();
                using (var transaction = await connection.BeginRetriableTransactionAsync())
                {
                    var cmd = transaction.CreateBatchDmlCommand();
                    cmd.Add(sql1);
                    cmd.Add(sql2);
                    try
                    {
                        await cmd.ExecuteNonQueryAsync();
                        Assert.True(false, "Missing expected exception");
                    }
                    catch (SpannerBatchNonQueryException e)
                    {
                        Assert.Contains("UPDATE statement misses WHERE clause", e.Message);
                        Assert.Equal(new List<long> { 1 }, e.SuccessfulCommandResults);
                    }
                    // Change the result of the first statement and abort the transaction.
                    // The retry should now fail, even though the error code and message is the same.
                    _fixture.SpannerMock.AddOrUpdateStatementResult(sql1, StatementResult.CreateUpdateCount(2));
                    _fixture.SpannerMock.AbortTransaction(ByteString.FromBase64(transaction.TransactionId.Id));
                    try
                    {
                        await transaction.CommitAsync();
                        Assert.True(false, "Missing expected exception");
                    }
                    catch (SpannerAbortedDueToConcurrentModificationException)
                    {
                        Assert.Equal(1, transaction.RetryCount);
                    }
                }
            }
        }

        [Fact]
        public async void ReadWriteTransaction_QueryFullyConsumed_CanBeRetried()
        {
            string sql = "SELECT Id FROM Foo";
            _fixture.SpannerMock.AddOrUpdateStatementResult(sql, StatementResult.CreateSingleColumnResultSet(SpannerDbType.Int64, "Id", 1));
            string connectionString = $"Data Source=projects/p1/instances/i1/databases/d1;Host={_fixture.Host};Port={_fixture.Port}";
            using (var connection = new SpannerConnection(connectionString, ChannelCredentials.Insecure))
            {
                await connection.OpenAsync();
                using (var transaction = await connection.BeginRetriableTransactionAsync())
                {
                    var cmd = connection.CreateSelectCommand(sql);
                    cmd.Transaction = transaction;
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            Assert.Equal(1, reader.GetInt64(reader.GetOrdinal("Id")));
                        }
                    }
                    // Abort the transaction on the mock server. The transaction should be able to internally retry.
                    _fixture.SpannerMock.AbortTransaction(ByteString.FromBase64(transaction.TransactionId.Id));
                    await transaction.CommitAsync();
                    Assert.Equal(1, transaction.RetryCount);
                }
            }
        }

        [Fact]
        public async void ReadWriteTransaction_QueryWithSameException_CanBeRetried()
        {
            string sql = "SELECT Id FROM Foo";
            _fixture.SpannerMock.AddOrUpdateStatementResult(sql, StatementResult.CreateException(new RpcException(new Status(StatusCode.NotFound, "Table not found: Foo"))));
            string connectionString = $"Data Source=projects/p1/instances/i1/databases/d1;Host={_fixture.Host};Port={_fixture.Port}";
            using (var connection = new SpannerConnection(connectionString, ChannelCredentials.Insecure))
            {
                await connection.OpenAsync();
                using (var transaction = await connection.BeginRetriableTransactionAsync())
                {
                    var cmd = connection.CreateSelectCommand(sql);
                    cmd.Transaction = transaction;
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        // Any query error is thrown by the first call to reader.ReadAsync();
                        try
                        {
                            while (await reader.ReadAsync()) { }
                        }
                        catch (SpannerException e) when (e.ErrorCode == ErrorCode.NotFound)
                        {
                            Assert.Contains("Table not found: Foo", e.InnerException.Message);
                        }
                    }
                    // Abort the transaction on the mock server. The transaction should be able to internally retry.
                    _fixture.SpannerMock.AbortTransaction(ByteString.FromBase64(transaction.TransactionId.Id));
                    await transaction.CommitAsync();
                    Assert.Equal(1, transaction.RetryCount);
                }
            }
        }

        [Fact]
        public async void ReadWriteTransaction_QueryFullyConsumed_WithModifiedResults_FailsRetry()
        {
            string sql = "SELECT Id FROM Foo";
            _fixture.SpannerMock.AddOrUpdateStatementResult(sql, StatementResult.CreateSingleColumnResultSet(SpannerDbType.Int64, "Id", 1));
            string connectionString = $"Data Source=projects/p1/instances/i1/databases/d1;Host={_fixture.Host};Port={_fixture.Port}";
            using (var connection = new SpannerConnection(connectionString, ChannelCredentials.Insecure))
            {
                await connection.OpenAsync();
                using (var transaction = await connection.BeginRetriableTransactionAsync())
                {
                    var cmd = connection.CreateSelectCommand(sql);
                    cmd.Transaction = transaction;
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            Assert.Equal(1, reader.GetInt64(reader.GetOrdinal("Id")));
                        }
                    }
                    // Change the result of the query on the server and abort the transaction.
                    // The retry should now fail.
                    _fixture.SpannerMock.AddOrUpdateStatementResult(sql, StatementResult.CreateSingleColumnResultSet(SpannerDbType.Int64, "Id", 2));
                    _fixture.SpannerMock.AbortTransaction(ByteString.FromBase64(transaction.TransactionId.Id));
                    try
                    {
                        await transaction.CommitAsync();
                        Assert.True(false, "Missing expected exception");
                    }
                    catch (SpannerAbortedDueToConcurrentModificationException)
                    {
                        Assert.Equal(1, transaction.RetryCount);
                    }
                }
            }
        }

        [Fact]
        public async void ReadWriteTransaction_QueryWithError_AndThenDifferentError_FailsRetry()
        {
            string sql = "SELECT Id FROM Foo";
            _fixture.SpannerMock.AddOrUpdateStatementResult(sql, StatementResult.CreateException(new RpcException(new Status(StatusCode.NotFound, "Table not found: Foo"))));
            string connectionString = $"Data Source=projects/p1/instances/i1/databases/d1;Host={_fixture.Host};Port={_fixture.Port}";
            using (var connection = new SpannerConnection(connectionString, ChannelCredentials.Insecure))
            {
                await connection.OpenAsync();
                using (var transaction = await connection.BeginRetriableTransactionAsync())
                {
                    var cmd = connection.CreateSelectCommand(sql);
                    cmd.Transaction = transaction;
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        // Any query error is thrown by the first call to reader.ReadAsync();
                        try
                        {
                            while (await reader.ReadAsync()) { }
                        }
                        catch (SpannerException e) when (e.ErrorCode == ErrorCode.NotFound)
                        {
                            Assert.Contains("Table not found: Foo", e.InnerException.Message);
                        }
                    }
                    // Change the error returned by the query on the server and abort the transaction.
                    // The retry should now fail.
                    _fixture.SpannerMock.AddOrUpdateStatementResult(sql, StatementResult.CreateException(new RpcException(new Status(StatusCode.PermissionDenied, "Permission denied for table Foo"))));
                    _fixture.SpannerMock.AbortTransaction(ByteString.FromBase64(transaction.TransactionId.Id));
                    try
                    {
                        await transaction.CommitAsync();
                        Assert.True(false, "Missing expected exception");
                    }
                    catch (SpannerAbortedDueToConcurrentModificationException)
                    {
                        Assert.Equal(1, transaction.RetryCount);
                    }
                }
            }
        }

        [Fact]
        public async void ReadWriteTransaction_QueryWithError_AndThenNoError_FailsRetry()
        {
            string sql = "SELECT Id FROM Foo";
            _fixture.SpannerMock.AddOrUpdateStatementResult(sql, StatementResult.CreateException(new RpcException(new Status(StatusCode.NotFound, "Table not found: Foo"))));
            string connectionString = $"Data Source=projects/p1/instances/i1/databases/d1;Host={_fixture.Host};Port={_fixture.Port}";
            using (var connection = new SpannerConnection(connectionString, ChannelCredentials.Insecure))
            {
                await connection.OpenAsync();
                using (var transaction = await connection.BeginRetriableTransactionAsync())
                {
                    var cmd = connection.CreateSelectCommand(sql);
                    cmd.Transaction = transaction;
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        // Any query error is thrown by the first call to reader.ReadAsync();
                        try
                        {
                            while (await reader.ReadAsync()) { }
                        }
                        catch (SpannerException e) when (e.ErrorCode == ErrorCode.NotFound)
                        {
                            Assert.Contains("Table not found: Foo", e.InnerException.Message);
                        }
                    }
                    // Remove the error returned by the query on the server and abort the transaction.
                    // The retry should now fail.
                    _fixture.SpannerMock.AddOrUpdateStatementResult(sql, StatementResult.CreateSingleColumnResultSet(SpannerDbType.Int64, "Id", 1));
                    _fixture.SpannerMock.AbortTransaction(ByteString.FromBase64(transaction.TransactionId.Id));
                    try
                    {
                        await transaction.CommitAsync();
                        Assert.True(false, "Missing expected exception");
                    }
                    catch (SpannerAbortedDueToConcurrentModificationException)
                    {
                        Assert.Equal(1, transaction.RetryCount);
                    }
                }
            }
        }

        [Fact]
        public async void ReadWriteTransaction_QueryFullyConsumed_AndThenError_FailsRetry()
        {
            string sql = "SELECT Id FROM Foo";
            _fixture.SpannerMock.AddOrUpdateStatementResult(sql, StatementResult.CreateSingleColumnResultSet(SpannerDbType.Int64, "Id", 1));
            string connectionString = $"Data Source=projects/p1/instances/i1/databases/d1;Host={_fixture.Host};Port={_fixture.Port}";
            using (var connection = new SpannerConnection(connectionString, ChannelCredentials.Insecure))
            {
                await connection.OpenAsync();
                using (var transaction = await connection.BeginRetriableTransactionAsync())
                {
                    var cmd = connection.CreateSelectCommand(sql);
                    cmd.Transaction = transaction;
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            Assert.Equal(1, reader.GetInt64(reader.GetOrdinal("Id")));
                        }
                    }
                    // Replace the result returned by the query on the server with an error and abort the transaction.
                    // The retry should now fail.
                    _fixture.SpannerMock.AddOrUpdateStatementResult(sql, StatementResult.CreateException(new RpcException(new Status(StatusCode.NotFound, "Table not found: Foo"))));
                    _fixture.SpannerMock.AbortTransaction(ByteString.FromBase64(transaction.TransactionId.Id));
                    try
                    {
                        await transaction.CommitAsync();
                        Assert.True(false, "Missing expected exception");
                    }
                    catch (SpannerAbortedDueToConcurrentModificationException)
                    {
                        Assert.Equal(1, transaction.RetryCount);
                    }
                }
            }
        }

        [Fact]
        public async void ReadWriteTransaction_QueryHalfConsumed_WithSameResults_CanBeRetried()
        {
            string sql = "SELECT Id FROM Foo";
            // Create a result set with 2 rows.
            _fixture.SpannerMock.AddOrUpdateStatementResult(sql, StatementResult.CreateSingleColumnResultSet(SpannerDbType.Int64, "Id", 1, 2));
            string connectionString = $"Data Source=projects/p1/instances/i1/databases/d1;Host={_fixture.Host};Port={_fixture.Port}";
            using (var connection = new SpannerConnection(connectionString, ChannelCredentials.Insecure))
            {
                await connection.OpenAsync();
                using (var transaction = await connection.BeginRetriableTransactionAsync())
                {
                    var cmd = connection.CreateSelectCommand(sql);
                    cmd.Transaction = transaction;
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        // Only consume the first row of the reader.
                        Assert.True(await reader.ReadAsync());
                        Assert.Equal(1, reader.GetInt64(reader.GetOrdinal("Id")));
                    }
                    // Abort the transaction on the mock server. The transaction should be able to internally retry.
                    _fixture.SpannerMock.AbortTransaction(ByteString.FromBase64(transaction.TransactionId.Id));
                    await transaction.CommitAsync();
                    Assert.Equal(1, transaction.RetryCount);
                }
            }
        }

        [Fact]
        public async void ReadWriteTransaction_QueryHalfConsumed_WithDifferentUnseenResults_CanBeRetried()
        {
            string sql = "SELECT Id FROM Foo";
            // Create a result set with 2 rows.
            _fixture.SpannerMock.AddOrUpdateStatementResult(sql, StatementResult.CreateSingleColumnResultSet(SpannerDbType.Int64, "Id", 1, 2));
            string connectionString = $"Data Source=projects/p1/instances/i1/databases/d1;Host={_fixture.Host};Port={_fixture.Port}";
            using (var connection = new SpannerConnection(connectionString, ChannelCredentials.Insecure))
            {
                await connection.OpenAsync();
                using (var transaction = await connection.BeginRetriableTransactionAsync())
                {
                    var cmd = connection.CreateSelectCommand(sql);
                    cmd.Transaction = transaction;
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        // Only consume the first row of the reader.
                        Assert.True(await reader.ReadAsync());
                        Assert.Equal(1, reader.GetInt64(reader.GetOrdinal("Id")));
                    }
                    // Change the second row of the result of the query. That row has never been seen by the transaction
                    // and should therefore not cause any retry to abort.
                    _fixture.SpannerMock.AddOrUpdateStatementResult(sql, StatementResult.CreateSingleColumnResultSet(SpannerDbType.Int64, "Id", 1, 3));
                    _fixture.SpannerMock.AbortTransaction(ByteString.FromBase64(transaction.TransactionId.Id));
                    await transaction.CommitAsync();
                    Assert.Equal(1, transaction.RetryCount);
                }
            }
        }

        [Fact]
        public async void ReadWriteTransaction_QueryAbortsHalfway_WithSameResults_CanBeRetried()
        {
            string sql = "SELECT Id FROM Foo";
            // Create a result set with 2 rows.
            _fixture.SpannerMock.AddOrUpdateStatementResult(sql, StatementResult.CreateSingleColumnResultSet(SpannerDbType.Int64, "Id", 1, 2));
            // The following will cause the ExecuteStreamingSql method on the mock server to return an Aborted error on stream index 1 (i.e. before the row with value 2 is returned).
            // This simulates a transaction that is aborted while a streaming result set is still being returned to the client.
            _fixture.SpannerMock.AddOrUpdateExecutionTime(nameof(MockSpannerService.ExecuteStreamingSql), ExecutionTime.StreamException(MockSpannerService.CreateAbortedException(), 1));
            string connectionString = $"Data Source=projects/p1/instances/i1/databases/d1;Host={_fixture.Host};Port={_fixture.Port}";
            using (var connection = new SpannerConnection(connectionString, ChannelCredentials.Insecure))
            {
                await connection.OpenAsync();
                using (var transaction = await connection.BeginRetriableTransactionAsync())
                {
                    var cmd = connection.CreateSelectCommand(sql);
                    cmd.Transaction = transaction;
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        // Only the first row of the reader.
                        Assert.True(await reader.ReadAsync());
                        Assert.Equal(1, reader.GetInt64(reader.GetOrdinal("Id")));
                        // Try to get the second row of the result. This should succeed, even though the transaction
                        // was aborted, retried and the reader was re-initialized under the hood.
                        Assert.True(await reader.ReadAsync());
                        Assert.Equal(2, reader.GetInt64(reader.GetOrdinal("Id")));
                        // Ensure that there are no more rows in the results.
                        Assert.False(await reader.ReadAsync());
                    }
                    // Check that the transaction really retried.
                    Assert.Equal(1, transaction.RetryCount);
                }
            }
        }

        [Fact]
        public async void ReadWriteTransaction_QueryAbortsHalfway_WithDifferentUnseenResults_CanBeRetried()
        {
            string sql = "SELECT Id FROM Foo";
            // Create a result set with 2 rows.
            _fixture.SpannerMock.AddOrUpdateStatementResult(sql, StatementResult.CreateSingleColumnResultSet(SpannerDbType.Int64, "Id", 1, 2));
            // The following will cause the ExecuteStreamingSql method on the mock server to return an Aborted error on stream index 1 (i.e. before the row with value 2 is returned).
            // This simulates a transaction that is aborted while a streaming result set is still being returned to the client.
            _fixture.SpannerMock.AddOrUpdateExecutionTime(nameof(MockSpannerService.ExecuteStreamingSql), ExecutionTime.StreamException(MockSpannerService.CreateAbortedException(), 1));
            string connectionString = $"Data Source=projects/p1/instances/i1/databases/d1;Host={_fixture.Host};Port={_fixture.Port}";
            using (var connection = new SpannerConnection(connectionString, ChannelCredentials.Insecure))
            {
                await connection.OpenAsync();
                using (var transaction = await connection.BeginRetriableTransactionAsync())
                {
                    var cmd = connection.CreateSelectCommand(sql);
                    cmd.Transaction = transaction;
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        // Only the first row of the reader.
                        Assert.True(await reader.ReadAsync());
                        Assert.Equal(1, reader.GetInt64(reader.GetOrdinal("Id")));

                        // Now change the result of the query, but only for the second row which has not yet been
                        // seen by this transaction.
                        _fixture.SpannerMock.AddOrUpdateStatementResult(sql, StatementResult.CreateSingleColumnResultSet(SpannerDbType.Int64, "Id", 1, 3));
                        // Try to get the second row of the result. This should succeed, even though the transaction
                        // was aborted, retried and the reader was re-initialized under the hood. The retry succeeds
                        // because only data that had not yet been seen by this transaction was changed.
                        Assert.True(await reader.ReadAsync());
                        Assert.Equal(3, reader.GetInt64(reader.GetOrdinal("Id")));
                        // Ensure that there are no more rows in the results.
                        Assert.False(await reader.ReadAsync());
                    }
                    // Check that the transaction really retried.
                    Assert.Equal(1, transaction.RetryCount);
                }
            }
        }

        [Fact]
        public async void ReadWriteTransaction_QueryAbortsHalfway_WithDifferentResults_FailsRetry()
        {
            string sql = "SELECT Id FROM Foo";
            // Create a result set with 2 rows.
            _fixture.SpannerMock.AddOrUpdateStatementResult(sql, StatementResult.CreateSingleColumnResultSet(SpannerDbType.Int64, "Id", 1, 2));
            // The following will cause the ExecuteStreamingSql method on the mock server to return an Aborted error on stream index 1 (i.e. before the row with value 2 is returned).
            // This simulates a transaction that is aborted while a streaming result set is still being returned to the client.
            _fixture.SpannerMock.AddOrUpdateExecutionTime(nameof(MockSpannerService.ExecuteStreamingSql), ExecutionTime.StreamException(MockSpannerService.CreateAbortedException(), 1));
            string connectionString = $"Data Source=projects/p1/instances/i1/databases/d1;Host={_fixture.Host};Port={_fixture.Port}";
            using (var connection = new SpannerConnection(connectionString, ChannelCredentials.Insecure))
            {
                await connection.OpenAsync();
                using (var transaction = await connection.BeginRetriableTransactionAsync())
                {
                    var cmd = connection.CreateSelectCommand(sql);
                    cmd.Transaction = transaction;
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        // Only the first row of the reader.
                        Assert.True(await reader.ReadAsync());
                        Assert.Equal(1, reader.GetInt64(reader.GetOrdinal("Id")));

                        // Now change the result of the query for the record that has already been seen.
                        _fixture.SpannerMock.AddOrUpdateStatementResult(sql, StatementResult.CreateSingleColumnResultSet(SpannerDbType.Int64, "Id", 3, 2));
                        // Try to get the second row of the result. This will now fail.
                        try
                        {
                            await reader.ReadAsync();
                            Assert.True(false, "Missing expected exception");
                        } catch (SpannerAbortedDueToConcurrentModificationException)
                        {
                            Assert.Equal(1, transaction.RetryCount);
                        }
                    }
                }
            }
        }
    }
}
