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
using System.Text;
using System.Threading;
using Xunit.Abstractions;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    /// <summary>
    /// Base class for all transaction tests, populating the transaction table on construction.
    /// </summary>
    public abstract class TransactionTestBase
    {
        protected readonly TransactionTableFixture _fixture;

        /// <summary>
        /// Key just for this test.
        /// </summary>
        protected readonly string _key;
        protected readonly HistoryEntry _oldestEntry;
        protected readonly HistoryEntry _newestEntry;

        public TransactionTestBase(TransactionTableFixture fixture, ITestOutputHelper outputHelper)
        {
            _fixture = fixture;
#if LoggingOn
            SpannerConnection.ConnectionPoolOptions.LogLevel = LogLevel.Debug;
            SpannerConnection.ConnectionPoolOptions.LogPerformanceTraces = true;
            SpannerConnection.ConnectionPoolOptions.PerformanceTraceLogInterval = 1000;
#endif
            TestLogger.TestOutputHelper = outputHelper;
            _key = Guid.NewGuid().ToString();
            (_oldestEntry, _newestEntry) = PopulateTableForTest(fixture, _key);
        }

        protected SpannerCommand CreateSelectAllCommandForKey(SpannerConnection connection) =>
            connection.CreateSelectCommand(
                $"SELECT * FROM {_fixture.TableName} WHERE K=@k",
                new SpannerParameterCollection { { "k", SpannerDbType.String, _key } });

        private static (HistoryEntry oldest, HistoryEntry newest) PopulateTableForTest(TransactionTableFixture fixture, string key)
        {
            HistoryEntry oldest = default, newest = default;
            using (var connection = fixture.GetConnection())
            {
                connection.Open();

                SpannerCommand command = connection.CreateInsertOrUpdateCommand(fixture.TableName);
                command.Parameters.Add("K", SpannerDbType.String, key);
                var valueParameter = command.Parameters.Add("StringValue", SpannerDbType.String);

                // 1st update with TestKey
                RetryHelpers.RetryOnce(() =>
                {
                    using (var tx = connection.BeginTransaction())
                    {
                        command.Transaction = tx;
                        valueParameter.Value = Guid.NewGuid().ToString();
                        command.ExecuteNonQuery();
                        tx.Commit(out var timestamp);
                        oldest = new HistoryEntry((string)valueParameter.Value, timestamp.Value);
                    }
                });

                Thread.Sleep(250);

                // 2nd update
                RetryHelpers.RetryOnce(() =>
                {
                    using (var tx = connection.BeginTransaction())
                    {
                        command.Transaction = tx;
                        command.CommandText = $"UPDATE {fixture.TableName}";
                        valueParameter.Value = Guid.NewGuid().ToString();
                        command.ExecuteNonQuery();
                        tx.Commit();
                    }
                });

                Thread.Sleep(250);

                // 3rd update
                RetryHelpers.RetryOnce(() =>
                {
                    using (var tx = connection.BeginTransaction())
                    {
                        command.Transaction = tx;
                        valueParameter.Value = Guid.NewGuid().ToString();
                        command.ExecuteNonQuery();
                        tx.Commit(out var timestamp);
                        newest = new HistoryEntry((string)valueParameter.Value, timestamp.Value);
                    }
                });

                // Wait for time to pass after this
                Thread.Sleep(250);
            }
            return (oldest, newest);
        }


        protected class HistoryEntry
        {
            public string Value { get; }
            public DateTime Timestamp { get; }

            public HistoryEntry(string value, DateTime timestamp)
            {
                Value = value;
                Timestamp = timestamp;
            }
        }

    }
}
