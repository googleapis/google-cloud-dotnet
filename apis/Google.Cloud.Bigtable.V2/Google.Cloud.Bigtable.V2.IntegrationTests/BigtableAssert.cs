// Copyright 2017 Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Bigtable.V2.IntegrationTests
{
    internal static class BigtableAssert
    {
        public static async Task HasNoValuesAsync(
            BigtableClient client,
            TableName tableName,
            BigtableByteString rowKey)
        {
            // TODO: Use cleaner API when available
            var response = client.ReadRows(new ReadRowsRequest
            {
                TableName = tableName.ToString(),
                Rows = new RowSet { RowKeys = { rowKey } }
            });

            while (await response.ResponseStream.MoveNext(default))
            {
                var current = response.ResponseStream.Current;
                foreach (var chunk in current.Chunks)
                {
                    Assert.True(false, $"No chunks expected for the row at {rowKey.Value.ToStringUtf8()}");
                }
            }
        }

        public static async Task HasSingleValueAsync(
            BigtableClient client,
            TableName tableName,
            BigtableByteString rowKey,
            string familyName,
            BigtableByteString columnQualifier,
            BigtableByteString value,
            BigtableVersion? version = null)
        {
            // TODO: Use cleaner API when available
            var response = client.ReadRows(new ReadRowsRequest
            {
                TableName = tableName.ToString(),
                Rows = new RowSet { RowKeys = { rowKey } }
            });

            bool had_value = false;
            while (await response.ResponseStream.MoveNext(default))
            {
                var current = response.ResponseStream.Current;
                foreach (var chunk in current.Chunks)
                {
                    Assert.Equal(rowKey.Value, chunk.RowKey);
                    Assert.Equal(familyName, chunk.FamilyName);
                    Assert.Equal(columnQualifier.Value, chunk.Qualifier);
                    Assert.Equal(value.Value, chunk.Value);
                    if (version != null)
                    {
                        Assert.Equal(version.Value.Micros, chunk.TimestampMicros);
                    }
                    had_value = true;
                }
            }
            Assert.True(had_value, "The value was not present.");
        }

        public static async Task DoesNotHaveValueAsync(
            BigtableClient client,
            TableName tableName,
            BigtableByteString rowKey,
            string familyName,
            BigtableByteString columnQualifier,
            BigtableByteString value,
            BigtableVersion? version = null)
        {
            bool has_value = await HasValueHelperAsync(
                client,
                tableName,
                rowKey,
                familyName,
                columnQualifier,
                value,
                version);
            Assert.False(has_value);
        }

        public static async Task HasValueAsync(
            BigtableClient client,
            TableName tableName,
            BigtableByteString rowKey,
            string familyName,
            BigtableByteString columnQualifier,
            BigtableByteString value,
            BigtableVersion? version = null)
        {
            bool has_value = await HasValueHelperAsync(
                client,
                tableName,
                rowKey,
                familyName,
                columnQualifier,
                value,
                version);
            Assert.True(has_value);
        }

        private static async Task<bool> HasValueHelperAsync(
            BigtableClient client,
            TableName tableName,
            BigtableByteString rowKey,
            string familyName,
            BigtableByteString columnQualifier,
            BigtableByteString value,
            BigtableVersion? version)
        {
            // TODO: Use cleaner API when available
            var response = client.ReadRows(new ReadRowsRequest
            {
                TableName = tableName.ToString(),
                Rows = new RowSet { RowKeys = { rowKey } }
            });

            bool had_value = false;
            while (await response.ResponseStream.MoveNext(default))
            {
                var current = response.ResponseStream.Current;
                BigtableByteString currentRowKey;
                string currentColumnFamily = null;
                foreach (var chunk in current.Chunks)
                {
                    if (!chunk.RowKey.IsEmpty)
                    {
                        currentRowKey = chunk.RowKey;
                    }
                    if (chunk.FamilyName != null)
                    {
                        currentColumnFamily = chunk.FamilyName;
                    }
                    Assert.Equal(rowKey, currentRowKey);
                    if (familyName == currentColumnFamily && columnQualifier.Value == chunk.Qualifier)
                    {
                        Assert.Equal(value.Value, chunk.Value);
                        if (version != null)
                        {
                            Assert.Equal(version.Value.Micros, chunk.TimestampMicros);
                        }
                        had_value = true;
                    }
                }
            }

            return had_value;
        }
    }
}
