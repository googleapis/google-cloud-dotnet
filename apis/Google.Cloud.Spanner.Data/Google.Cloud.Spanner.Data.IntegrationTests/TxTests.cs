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
    }
}
