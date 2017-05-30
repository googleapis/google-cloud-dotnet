using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    public class TxTests : IClassFixture<TestDatabaseFixture>
    {
        private readonly TestDatabaseFixture _testFixture;
        private string _key;
        private readonly List<HistoryEntry> _history = new List<HistoryEntry>();

        public TxTests(TestDatabaseFixture testFixture)
        {
            _testFixture = testFixture;
        }

        class HistoryEntry
        {
            public string Value { get; set; }
            public DateTime Timestamp { get; set; }
        }

        private async Task WriteSampleRows()
        {
            if (string.IsNullOrEmpty(_key))
            {
                _key = Guid.NewGuid().ToString();
                using (var connection = await _testFixture.GetTestDatabaseConnectionAsync())
                {
                    // 1st update
                    var insupdate = connection.CreateInsertOrUpdateCommand("TX",
                        new SpannerParameterCollection
                        {
                            {"K", _key, SpannerDbType.String},
                            {"StringValue", Guid.NewGuid().ToString(), SpannerDbType.String}
                        });
                    _history.Add(new HistoryEntry
                    {
                        Value = insupdate.Parameters[1].Value.ToString(),
                        Timestamp = DateTime.UtcNow
                    });
                    await insupdate.ExecuteNonQueryAsync();

                    await Task.Delay(250);

                    // 2nd update
                    insupdate.CommandText = "UPDATE TX";
                    insupdate.Parameters[1].Value = Guid.NewGuid().ToString();
                    _history.Add(new HistoryEntry
                    {
                        Value = insupdate.Parameters[1].Value.ToString(),
                        Timestamp = DateTime.UtcNow
                    });
                    await insupdate.ExecuteNonQueryAsync();

                    await Task.Delay(250);

                    // 3rd update
                    insupdate.Parameters[1].Value = Guid.NewGuid().ToString();
                    _history.Add(new HistoryEntry
                    {
                        Value = insupdate.Parameters[1].Value.ToString(),
                        Timestamp = DateTime.UtcNow
                    });
                    await insupdate.ExecuteNonQueryAsync();
                }
            }
        }

        [Fact]
        public async Task TestReadStrong()
        {
            await WriteSampleRows();
            using (var connection = await _testFixture.GetTestDatabaseConnectionAsync())
            {
                await connection.OpenAsync();
                using (var tx = await connection.BeginReadOnlyTransactionAsync(TimestampBound.Strong))
                {
                    var cmd = connection.CreateSelectCommand("SELECT * FROM TX WHERE K=@k",
                        new SpannerParameterCollection { { "k", _key, SpannerDbType.String } });
                    cmd.Transaction = tx;
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            Assert.True(reader.GetFieldValue<string>(1) == _history[2].Value);
                            break;
                        }
                    }
                }
            }
        }

        [Fact]
        public async Task TestReadMin()
        {
            ArgumentException caughtException = null;

            await WriteSampleRows();
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

                var cmd = connection.CreateSelectCommand("SELECT * FROM TX WHERE K=@k",
                    new SpannerParameterCollection { { "k", _key, SpannerDbType.String } });
                using (var reader = await cmd.ExecuteReaderAsync(
                    TimestampBound.OfMinReadTimestamp(_history[2].Timestamp) ))
                {
                    while (await reader.ReadAsync())
                    {
                        Assert.True(reader.GetFieldValue<string>(1) == _history[2].Value);
                        break;
                    }
                }
            }
            Assert.True(caughtException != null);
        }

        [Fact]
        public async Task TestReadExact()
        {
            await WriteSampleRows();
            using (var connection = await _testFixture.GetTestDatabaseConnectionAsync())
            {
                await connection.OpenAsync();
                using (var tx = await connection.BeginReadOnlyTransactionAsync(
                    TimestampBound.OfReadTimestamp(_history[0].Timestamp)))
                {
                    Assert.True(tx.Mode == TransactionMode.ReadOnly);
                    Assert.True(Equals(tx.TimeStampBound.TimeStamp, _history[0].Timestamp));

                    var cmd = connection.CreateSelectCommand("SELECT * FROM TX WHERE K=@k",
                        new SpannerParameterCollection { { "k", _key, SpannerDbType.String } });
                    cmd.Transaction = tx;
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            Assert.True(reader.GetFieldValue<string>(1) == _history[0].Value);
                            break;
                        }
                    }
                }
            }
        }

        [Fact]
        public async Task TestReadStaleMax()
        {
            ArgumentException caughtException = null;

            await WriteSampleRows();
            using (var connection = await _testFixture.GetTestDatabaseConnectionAsync())
            {
                await connection.OpenAsync();
                try
                {
                    await connection.BeginReadOnlyTransactionAsync(
                        TimestampBound.OfMaxStaleness(TimeSpan.FromSeconds(50)));
                } catch (ArgumentException ex)
                {
                    caughtException = ex;
                }


                var cmd = connection.CreateSelectCommand("SELECT * FROM TX WHERE K=@k",
                    new SpannerParameterCollection { { "k", _key, SpannerDbType.String } });
                using (var reader = await cmd.ExecuteReaderAsync(
                                    TimestampBound.OfMaxStaleness(TimeSpan.FromMilliseconds(5))))
                {
                    while (await reader.ReadAsync())
                    {
                        Assert.True(reader.GetFieldValue<string>(1) == _history[2].Value);
                        break;
                    }
                }
            }
            Assert.True(caughtException != null);
        }

        [Fact]
        public async Task TestReadStaleExact()
        {
            await WriteSampleRows();
            using (var connection = await _testFixture.GetTestDatabaseConnectionAsync())
            {
                await connection.OpenAsync();
                using (var tx = await connection.BeginReadOnlyTransactionAsync(
                    TimestampBound.OfExactStaleness(TimeSpan.FromSeconds(50))))
                {
                    Assert.True(tx.Mode == TransactionMode.ReadOnly);
                    Assert.True(Equals(tx.TimeStampBound.Staleness, TimeSpan.FromSeconds(50)));

                    var cmd = connection.CreateSelectCommand("SELECT * FROM TX WHERE K=@k",
                        new SpannerParameterCollection { { "k", _key, SpannerDbType.String } });
                    cmd.Transaction = tx;
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            Assert.True(false, "We should have read no rows at this time!");
                            break;
                        }
                    }
                }
            }
        }
    }
}
