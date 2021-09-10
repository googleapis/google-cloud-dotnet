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
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    /// <summary>
    /// Base class for test fixtures that need a common table structure (just key/value pairs) populated
    /// in a common way.
    /// </summary>
    public class CommonDataTableFixture : SpannerTableFixture
    {
        public int RowCount { get; } = 15;

        public CommonDataTableFixture(string tableName) : base(tableName)
        {
        }

        protected virtual bool ShouldCreateIndexes() => false;

        protected override void CreateTable()
        {
            ExecuteDdl($@"CREATE TABLE {TableName} (
                                            Key                STRING(MAX) NOT NULL,
                                            StringValue        STRING(MAX),
                                          ) PRIMARY KEY (Key)");

            if (ShouldCreateIndexes())
            {
                ExecuteDdl($"CREATE INDEX TestTableByValue ON {TableName}(StringValue)");
                ExecuteDdl($"CREATE INDEX TestTableByValueDesc ON {TableName}(StringValue DESC)");
            }
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
                Assert.True(connection.IsOpen);
                RetryHelpers.ExecuteWithRetry(() =>
                {
                    using (var tx = connection.BeginTransaction())
                    {
                        var cmd = connection.CreateInsertCommand(TableName);
                        var keyParameter = cmd.Parameters.Add("Key", SpannerDbType.String);
                        var valueParameter = cmd.Parameters.Add("StringValue", SpannerDbType.String);

                        cmd.Transaction = tx;

                        for (var i = 0; i < RowCount - 1; ++i)
                        {
                            keyParameter.Value = "k" + i;
                            valueParameter.Value = "v" + i;
                            cmd.ExecuteNonQuery();
                        }

                        // And one extra row, with a null value.
                        keyParameter.Value = "kNull";
                        valueParameter.Value = DBNull.Value;
                        cmd.ExecuteNonQuery();

                        tx.Commit();
                    }
                });
             }
        }
    }
}
