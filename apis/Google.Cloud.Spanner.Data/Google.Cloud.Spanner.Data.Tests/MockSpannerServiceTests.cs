using Google.Cloud.Spanner.V1;
using Google.Protobuf;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests
{
    public class MockSpannerServerTests : IClassFixture<SpannerMockServerFixture>
    {
        SpannerMockServerFixture _fixture;

        public MockSpannerServerTests(SpannerMockServerFixture service)
        {
            this._fixture = service;
            // Add a simple SELECT 1 result to the mock server to be available for all test cases.
            _fixture.SpannerMock.AddOrUpdateStatementResult("SELECT 1", StatementResult.CreateSelect1ResultSet());
        }

        [Fact]
        public void BatchCreateSessions()
        {
            SpannerClientBuilder builder = new SpannerClientBuilder();
            builder.Endpoint = _fixture.Endpoint;
            builder.ChannelCredentials = ChannelCredentials.Insecure;
            SpannerClient client = builder.Build();
            BatchCreateSessionsRequest request = new BatchCreateSessionsRequest();
            request.Database = "projects/p1/instances/i1/databases/d1";
            request.SessionCount = 25;
            request.SessionTemplate = new Session();
            BatchCreateSessionsResponse response = client.BatchCreateSessions(request);
            Assert.Equal(25, response.Session.Count);
        }

        [Fact]
        public async void SingleUseSelect()
        {
            string connectionString = $"Data Source=projects/p1/instances/i1/databases/d1;Host={_fixture.Host};Port={_fixture.Port}";
            // Create connection to Cloud Spanner.
            using (var connection = new SpannerConnection(connectionString, ChannelCredentials.Insecure))
            {
                SpannerCommand cmd = connection.CreateSelectCommand("SELECT 1");
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        Assert.Equal(1, reader.GetInt64(0));
                    }
                }
            }
        }

        [Fact]
        public async void ReadOnlyTxSelect()
        {
            string connectionString = $"Data Source=projects/p1/instances/i1/databases/d1;Host={_fixture.Host};Port={_fixture.Port}";
            using (var connection = new SpannerConnection(connectionString, ChannelCredentials.Insecure))
            {
                using (var transaction = await connection.BeginReadOnlyTransactionAsync())
                {
                    SpannerCommand cmd = connection.CreateSelectCommand("SELECT 1");
                    cmd.Transaction = transaction;
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            Assert.Equal(1, reader.GetInt64(0));
                        }
                    }
                }
            }
        }

        [Fact]
        public async void WriteMutations()
        {
            string connectionString = $"Data Source=projects/p1/instances/i1/databases/d1;Host={_fixture.Host};Port={_fixture.Port}";
            using (var connection = new SpannerConnection(connectionString, ChannelCredentials.Insecure))
            {
                SpannerCommand cmd = connection.CreateInsertOrUpdateCommand("Singers", new SpannerParameterCollection {
                        {"SingerId", SpannerDbType.Int64, 1},
                        {"FirstName", SpannerDbType.String, "FirstName1"},
                        {"LastName", SpannerDbType.String, "LastName1"},
                    });
                await cmd.ExecuteNonQueryAsync();
            }
            List<IMessage> requests = _fixture.SpannerMock.Requests();
            CommitRequest commit = (CommitRequest)requests.Last();
            Assert.Equal(Mutation.OperationOneofCase.InsertOrUpdate, commit.Mutations.First().OperationCase);
            Assert.Equal("Singers", commit.Mutations.First().InsertOrUpdate.Table);
        }

        [Fact]
        public async void ReadWriteTransaction()
        {
            decimal initialBudget1 = 1225250.00m;
            decimal initialBudget2 = 2250198.28m;
            _fixture.SpannerMock.AddOrUpdateStatementResult(
                "SELECT MarketingBudget FROM Albums WHERE SingerId = 1 AND AlbumId = 1",
                StatementResult.CreateSingleColumnResultSet(SpannerDbType.Numeric, "MarketingBudget", initialBudget1));
            _fixture.SpannerMock.AddOrUpdateStatementResult(
                "SELECT MarketingBudget FROM Albums WHERE SingerId = 2 AND AlbumId = 2",
                StatementResult.CreateSingleColumnResultSet(SpannerDbType.Numeric, "MarketingBudget", initialBudget2));
            string connectionString = $"Data Source=projects/p1/instances/i1/databases/d1;Host={_fixture.Host};Port={_fixture.Port}";

            decimal transferAmount = 200000;
            decimal secondBudget = 0;
            decimal firstBudget = 0;

            using (var connection = new SpannerConnection(connectionString, ChannelCredentials.Insecure))
            {
                await connection.OpenAsync();
                using (var transaction = await connection.BeginTransactionAsync())
                {
                    // Create statement to select the second album's data.
                    var cmdLookup = connection.CreateSelectCommand(
                        "SELECT MarketingBudget FROM Albums WHERE SingerId = 2 AND AlbumId = 2");
                    cmdLookup.Transaction = transaction;
                    // Excecute the select query.
                    using (var reader = await cmdLookup.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            secondBudget = reader.GetNumeric(reader.GetOrdinal("MarketingBudget")).ToDecimal(LossOfPrecisionHandling.Throw);
                        }
                    }
                    // Read the first album's budget.
                    cmdLookup = connection.CreateSelectCommand(
                        "SELECT MarketingBudget FROM Albums WHERE SingerId = 1 AND AlbumId = 1");
                    cmdLookup.Transaction = transaction;
                    using (var reader = await cmdLookup.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            firstBudget = reader.GetNumeric(reader.GetOrdinal("MarketingBudget")).ToDecimal(LossOfPrecisionHandling.Throw);
                        }
                    }
                    // Specify update command parameters.
                    var cmd = connection.CreateUpdateCommand("Albums",
                        new SpannerParameterCollection
                        {
                            {"SingerId", SpannerDbType.Int64},
                            {"AlbumId", SpannerDbType.Int64},
                            {"MarketingBudget", SpannerDbType.Numeric},
                        });
                    cmd.Transaction = transaction;
                    // Update second album to remove the transfer amount.
                    secondBudget -= transferAmount;
                    cmd.Parameters["SingerId"].Value = 2;
                    cmd.Parameters["AlbumId"].Value = 2;
                    cmd.Parameters["MarketingBudget"].Value = secondBudget;
                    await cmd.ExecuteNonQueryAsync();
                    // Update first album to add the transfer amount.
                    firstBudget += transferAmount;
                    cmd.Parameters["SingerId"].Value = 1;
                    cmd.Parameters["AlbumId"].Value = 1;
                    cmd.Parameters["MarketingBudget"].Value = firstBudget;
                    await cmd.ExecuteNonQueryAsync();

                    await transaction.CommitAsync();
                }
                // Assert that the correct updates were sent.
                Stack<IMessage> requests = new Stack<IMessage>(_fixture.SpannerMock.Requests());
                Assert.Equal(typeof(CommitRequest), requests.Peek().GetType());
                CommitRequest commit = (CommitRequest)requests.Pop();
                Assert.Equal(2, commit.Mutations.Count);

                Mutation update1 = commit.Mutations.Last();
                Assert.Equal(Mutation.OperationOneofCase.Update, update1.OperationCase);
                Assert.Equal("Albums", update1.Update.Table);
                Assert.Equal("1", update1.Update.Values.ElementAt(0).Values.ElementAt(0).StringValue);
                Assert.Equal(
                    SpannerNumeric.FromDecimal(initialBudget1 + transferAmount, LossOfPrecisionHandling.Throw),
                    SpannerNumeric.Parse(update1.Update.Values.ElementAt(0).Values.ElementAt(2).StringValue));

                Mutation update2 = commit.Mutations.First();
                Assert.Equal(Mutation.OperationOneofCase.Update, update2.OperationCase);
                Assert.Equal("Albums", update2.Update.Table);
                Assert.Equal("2", update2.Update.Values.ElementAt(0).Values.ElementAt(0).StringValue);
                Assert.Equal(
                    SpannerNumeric.FromDecimal(initialBudget2 - transferAmount, LossOfPrecisionHandling.Throw),
                    SpannerNumeric.Parse(update2.Update.Values.ElementAt(0).Values.ElementAt(2).StringValue));
            }
        }
    }
}
