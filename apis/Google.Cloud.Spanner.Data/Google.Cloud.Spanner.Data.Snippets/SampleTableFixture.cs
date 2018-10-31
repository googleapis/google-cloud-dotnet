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
using Xunit;

namespace Google.Cloud.Spanner.Data.Snippets
{
    /// <summary>
    /// A table fixture that covers all Spanner types. The fixture doesn't populate any data,
    /// but tests should not depend on the table being empty as other tests may modify it.
    /// </summary>
    [CollectionDefinition(nameof(SampleTableFixture))]
    public class SampleTableFixture : SpannerTableFixture, ICollectionFixture<SampleTableFixture>
    {
        public int RowCount { get; } = 15;

        public SampleTableFixture() : base("TestTable")
        {
        }

        protected override void CreateTable()
        {
            ExecuteDdl($@"CREATE TABLE {TableName} (
                          Key                STRING(MAX) NOT NULL,
                          StringValue        STRING(MAX),
                          Int64Value         INT64,
                          ) PRIMARY KEY (Key)");

            ExecuteDdl($"CREATE INDEX {TableName}ByValue ON {TableName}(StringValue)");
            ExecuteDdl($"CREATE INDEX {TableName}ByValueDesc ON {TableName}(StringValue DESC)");
        }

        protected override void PopulateTable(bool fresh)
        {
            // If we're using an old table, assume that the data is okay.
            if (!fresh)
            {
                return;
            }
            using (var connection = GetConnection())
            {
                connection.Open();
                RetryHelpers.ExecuteWithRetry(() =>
                {
                    using (var tx = connection.BeginTransaction())
                    {
                        var cmd = connection.CreateInsertCommand(TableName);
                        var keyParameter = cmd.Parameters.Add("Key", SpannerDbType.String);
                        var stringValueParameter = cmd.Parameters.Add("StringValue", SpannerDbType.String);
                        var int64ValueParameter = cmd.Parameters.Add("Int64Value", SpannerDbType.Int64);
                        cmd.Transaction = tx;

                        for (var i = 0; i < RowCount; i++)
                        {
                            keyParameter.Value = "k" + i;
                            stringValueParameter.Value = "v" + i;
                            int64ValueParameter.Value = i;
                            cmd.ExecuteNonQuery();
                        }

                        tx.Commit();
                    }
                });
            }
        }
    }
}
