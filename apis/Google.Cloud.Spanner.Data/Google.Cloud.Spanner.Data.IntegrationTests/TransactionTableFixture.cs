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
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [CollectionDefinition(nameof(TransactionTableFixture))]
    public class TransactionTableFixture : SpannerTableFixture, ICollectionFixture<TransactionTableFixture>
    {
        /// <summary>
        /// A timestamp which was definitely after the table existed, but before any other test-specific keys were added.
        /// </summary>
        internal DateTime TimestampBeforeEntries { get; private set; }

        // Note: this *must* have an initializer here rather than in the constructor, as it's used before
        // the constructor body executes.
        public string TableName2 { get; } = "TxTable2";

        /// <summary>
        /// A reasonable staleness such that the table will exist this long before tests run, but shouldn't
        /// have any entries for TestKey. (The population process pauses for at least this long, and this should
        /// be longer than all the transaction tests take to run.)
        /// </summary>
        internal TimeSpan Staleness { get; } = TimeSpan.FromSeconds(30);

        public TransactionTableFixture() : base("TxTable")
        {
        }

        protected override void CreateTable()
        {
            ExecuteDdl($@"CREATE TABLE {TableName} (
                              K                   STRING(MAX) NOT NULL,
                              Int64Value          INT64,
                              StringValue         STRING(MAX),
                            ) PRIMARY KEY (K)");

            // Create a second table, only used in multi-table transaction tests. The alternative
            // would be to have a whole separate fixture just for those tests, creating two entirely
            // separate tables, which is far from ideal.
            ExecuteDdl($@"CREATE TABLE {TableName2} (
                              K                   STRING(MAX) NOT NULL,
                              Int64Value          INT64,
                              StringValue         STRING(MAX),
                            ) PRIMARY KEY (K)");
        }

        protected override void PopulateTable(bool fresh)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                SpannerCommand command = connection.CreateInsertOrUpdateCommand(TableName);
                var keyParameter = command.Parameters.Add("K", SpannerDbType.String, IdGenerator.FromGuid());
                var valueParameter = command.Parameters.Add("StringValue", SpannerDbType.String, IdGenerator.FromGuid());

                // Create a lowest-bound timestamp which is definitely valid, but not
                // associated with TestKey
                RetryHelpers.ExecuteWithRetry(() =>
                {
                    using (var tx = connection.BeginTransaction())
                    {
                        command.Transaction = tx;
                        command.ExecuteNonQuery();
                        tx.Commit(out var timestamp);
                        TimestampBeforeEntries = timestamp;
                    }
                });

                // It's a pity we have to do this, but otherwise it's hard to get reliable tests.
                Thread.Sleep(Staleness + TimeSpan.FromSeconds(2));
            }
        }
    }
}
