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
using System.Collections.Generic;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [CollectionDefinition(nameof(PartitionedReadTableFixture))]
    public class PartitionedReadTableFixture : SpannerTableFixture, ICollectionFixture<PartitionedReadTableFixture>
    {
        private const long NumPartitionReadRows = 10000;

        public IReadOnlyList<string> ColumnNames => new List<string> { "OrderID", "OrderDate", "Product" }.AsReadOnly();

        public PartitionedReadTableFixture() : base("PartitionedRead")
        {
        }

        protected override void CreateTable()
        {
            ExecuteDdl($@"CREATE TABLE {TableName} (
                                OrderID STRING(MAX) NOT NULL,
                                OrderDate TIMESTAMP,
                                Product STRING(MAX) NOT NULL
                            ) PRIMARY KEY (OrderID)");
        }

        protected override void PopulateTable(bool fresh)
        {
            // Assume old data is still valid
            if (!fresh)
            {
                return;
            }
            const int PartitionSize = 5000;

            using (var connection = GetConnection())
            {
                connection.Open();
                for (var i = 0; i < NumPartitionReadRows / PartitionSize; i++)
                {
                    RetryHelpers.ExecuteWithRetry(() =>
                    {
                        using (var tx = connection.BeginTransaction())
                        {
                            using (var cmd = connection.CreateInsertCommand(TableName))
                            {
                                var idParameter = cmd.Parameters.Add("OrderId", SpannerDbType.String);
                                var dateParameter = cmd.Parameters.Add("OrderDate", SpannerDbType.Timestamp);
                                var productParameter = cmd.Parameters.Add("Product", SpannerDbType.String);
                                cmd.Transaction = tx;
                                DateTime now = DateTime.UtcNow;
                                for (var x = 1; x < PartitionSize; x++)
                                {
                                    idParameter.Value = IdGenerator.FromGuid();
                                    dateParameter.Value = now.AddDays(-x);
                                    productParameter.Value = $"Widget#{x}";
                                    cmd.ExecuteNonQuery();
                                }
                                tx.Commit();
                            }
                        }
                    });
                }
            }
        }
    }
}
