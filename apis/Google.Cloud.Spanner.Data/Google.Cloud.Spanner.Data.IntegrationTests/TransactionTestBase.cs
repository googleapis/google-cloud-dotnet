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
using System.Threading;

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

        public TransactionTestBase(TransactionTableFixture fixture)
        {
            _fixture = fixture;
            _key = IdGenerator.FromGuid();
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
                RetryHelpers.ExecuteWithRetry(() =>
                {
                    using (var tx = connection.BeginTransaction())
                    {
                        command.Transaction = tx;
                        valueParameter.Value = IdGenerator.FromGuid();
                        command.ExecuteNonQuery();
                        tx.Commit(out var timestamp);
                        oldest = new HistoryEntry((string)valueParameter.Value, timestamp);
                    }
                });

                Thread.Sleep(250);

                // 2nd update
                RetryHelpers.ExecuteWithRetry(() =>
                {
                    using (var tx = connection.BeginTransaction())
                    {
                        command.Transaction = tx;
                        command.CommandText = $"UPDATE {fixture.TableName}";
                        valueParameter.Value = IdGenerator.FromGuid();
                        command.ExecuteNonQuery();
                        tx.Commit();
                    }
                });

                Thread.Sleep(250);

                // 3rd update
                RetryHelpers.ExecuteWithRetry(() =>
                {
                    using (var tx = connection.BeginTransaction())
                    {
                        command.Transaction = tx;
                        valueParameter.Value = IdGenerator.FromGuid();
                        command.ExecuteNonQuery();
                        tx.Commit(out var timestamp);
                        newest = new HistoryEntry((string)valueParameter.Value, timestamp);
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
