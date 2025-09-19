// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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

using Google.Api.Gax.Grpc;
using Google.Cloud.ClientTesting;
using Google.Cloud.Spanner.Data.CommonTesting;
using Google.Cloud.Spanner.V1;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests;
[Collection(nameof(AllTypesTableFixture))]
[CommonTestDiagnostics]
public class MultiplexSessionTests
{
    private readonly AllTypesTableFixture _fixture;

    public MultiplexSessionTests(AllTypesTableFixture fixture) =>
        _fixture = fixture;

    [Fact]
    [Trait(Constants.SupportedOnEmulator, Constants.No)]
    public async Task SessionCreationSucceeds()
    {
        MultiplexSession muxSession = await _fixture.GetMultiplexSession();

        Assert.NotNull(muxSession.Session);
        Assert.NotNull(muxSession.SessionName);

        // Use the underlying client to get the mux session from the server.
        SpannerClient client = muxSession.Client;
        var getSessionRequest = new GetSessionRequest
        {
            SessionName = muxSession.SessionName,
        };
        var matchingSession = client.GetSession(getSessionRequest);

        Assert.Equal(muxSession.SessionName, matchingSession.SessionName);
        Assert.True(matchingSession.Multiplexed);
    }

    [Fact]
    [Trait(Constants.SupportedOnEmulator, Constants.No)]
    public async Task RunReadWriteTransactionWithMultipleQueries()
    {
        MultiplexSession multiplexSession = await _fixture.GetMultiplexSession();
        Transaction transaction = new Transaction(multiplexSession, null, new TransactionOptions { ReadWrite = new TransactionOptions.Types.ReadWrite() }, false, null);
        String uniqueRowId = IdGenerator.FromGuid();
        // Query 1: Read some data before modification.
        var result = await ExecuteSelectQuery(transaction, uniqueRowId);
        Assert.NotNull(result);
        Assert.NotNull(transaction.PrecommitToken);
        Assert.NotNull(transaction.TransactionId);

        int preCommitTokenSeqNumber = transaction.PrecommitToken.SeqNum;

        // Query 2: Insert a new record.
        result = await ExecuteInsertInt64Value(transaction, uniqueRowId, 10);
        Assert.NotNull(result);
        Assert.NotNull(transaction.PrecommitToken);
        Assert.NotNull(transaction.Id);
        Assert.True(transaction.PrecommitToken.SeqNum >= preCommitTokenSeqNumber);

        preCommitTokenSeqNumber = transaction.PrecommitToken.SeqNum;

        // Commit the transaction
        var commitResponse = await transaction.CommitAsync(new CommitRequest(), null);
        Assert.NotNull(commitResponse);
        Assert.NotNull(transaction.Id);
    }

    [Fact]
    [Trait(Constants.SupportedOnEmulator, Constants.No)]
    public async Task TestMultipleTransactionWritesOnSameSession()
    {
        MultiplexSession multiplexSession = await _fixture.GetMultiplexSession();
        const int concurrentThreads = 5;
        String uniqueRowId = IdGenerator.FromGuid();

        try
        {
            var transactions = new Transaction[concurrentThreads];
            for (var i = 0; i < concurrentThreads; i++)
            {
                transactions[i] = new Transaction(multiplexSession, null, new TransactionOptions { ReadWrite = new TransactionOptions.Types.ReadWrite() }, false, null);
            }

            for (var i = 0; i < concurrentThreads; i++)
            {
                await IncrementByOneAsync(transactions[i], uniqueRowId);
            }

            Transaction fetchResultsTransaction = new Transaction(multiplexSession, null, new TransactionOptions { ReadWrite = new TransactionOptions.Types.ReadWrite() }, false, null);
            var fetched = await ExecuteSelectQuery(fetchResultsTransaction, uniqueRowId);

            var row = fetched.Rows.First();
            var actual = long.Parse(row.Values[1].StringValue);
            Assert.Equal(5, actual);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            Console.WriteLine(ex.InnerException?.ToString());
            throw;
        }
    }

    private async Task IncrementByOneAsync(Transaction transaction, string uniqueRowId, bool orphanTransaction = false)
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
                long current;

                var fetched = await ExecuteSelectQuery(transaction, uniqueRowId);
                if (fetched?.Rows.Any() == true)
                {
                    var row = fetched.Rows.First();
                    current = long.Parse(row.Values[1].StringValue);
                }
                else
                {
                    current = 0L;
                }


                ResultSet result;
                if (current == 0)
                {
                    result = await ExecuteInsertInt64Value(transaction, uniqueRowId, current + 1);
                }
                else
                {
                    result = await ExecuteUpdateInt64Value(transaction, uniqueRowId, current + 1);
                }

                await transaction.CommitAsync(new CommitRequest(), null);
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

    private async Task<ResultSet> ExecuteSelectQuery(Transaction transaction, String uniqueRowId)
    {
        var selectParams = new Dictionary<string, SpannerParameter>
        {
            { "id", new SpannerParameter { Value = Value.ForString(uniqueRowId) } }
        };
        var selectSql = $"SELECT K, Int64Value FROM {_fixture.TableName} WHERE K = @id";
        var request = new ExecuteSqlRequest
        {
            Sql = selectSql,
            Params = CreateStructFromParameters(selectParams),
        };

        return await transaction.ExecuteSqlAsync(request, null);
    }

    private async Task<ResultSet> ExecuteInsertInt64Value(Transaction transaction, String uniqueRowId, long insertValue)
    {
        var insertSql = $"INSERT {_fixture.TableName} (K, Int64Value) VALUES (@k, @int64Value)";
        var insertParams = new Dictionary<string, SpannerParameter>
        {
            { "k", new SpannerParameter { Value = Value.ForString(uniqueRowId) } },
            { "int64Value", new SpannerParameter("int64Value", SpannerDbType.Int64, insertValue) }
        };

        var request = new ExecuteSqlRequest
        {
            Sql = insertSql,
            Params = CreateStructFromParameters(insertParams),
        };
        return await transaction.ExecuteSqlAsync(request, null);
    }

    private async Task<ResultSet> ExecuteUpdateInt64Value(Transaction transaction, String uniqueRowId, long updateValue)
    {
        var updateSql = $"UPDATE {_fixture.TableName} SET Int64Value = @newIntValue WHERE K = @id";
        var updateParams = new Dictionary<string, SpannerParameter>
        {
            { "newIntValue", new SpannerParameter("newIntValue", SpannerDbType.Int64, updateValue) },
            { "id", new SpannerParameter { Value = Value.ForString(uniqueRowId) } }
         };

        var request = new ExecuteSqlRequest
        {
            Sql = updateSql,
            Params = CreateStructFromParameters(updateParams),
        };
        return await transaction.ExecuteSqlAsync(request, null);
    }

    /// <summary>
    /// Converts a dictionary of Spanner parameters to a Google.Protobuf.WellKnownTypes.Struct.
    /// </summary>
    private Struct CreateStructFromParameters(Dictionary<string, SpannerParameter> parameters)
    {
        var pbStruct = new Struct();
        var options = SpannerConversionOptions.Default;
        if (parameters != null)
        {
            foreach (var param in parameters)
            {
                var parameter = param.Value;
                var protobufValue = parameter.GetConfiguredSpannerDbType(options).ToProtobufValue(parameter.GetValidatedValue());
                pbStruct.Fields.Add(param.Key, protobufValue);
            }
        }
        return pbStruct;
    }
}
