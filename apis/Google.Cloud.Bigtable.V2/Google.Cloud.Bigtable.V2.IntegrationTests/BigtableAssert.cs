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

using Google.Cloud.Bigtable.Common.V2;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Bigtable.V2.IntegrationTests
{
    public static class BigtableAssert
    {
        public static async Task HasNoValuesAsync(
            BigtableClient client,
            TableName tableName,
            BigtableByteString rowKey,
            string familyName = null)
        {
            var filter = familyName == null
                ? RowFilters.PassAllFilter()
                : RowFilters.FamilyNameExact(familyName);
            Assert.Null(await client.ReadRowAsync(tableName, rowKey, filter));
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
            var row = await client.ReadRowAsync(tableName, rowKey);
            Assert.Equal(rowKey.Value, row.Key);

            HasSingleValue(row, familyName, columnQualifier, value, version);
        }

        public static void HasSingleValue(
            Row row,
            string familyName,
            BigtableByteString columnQualifier,
            BigtableByteString value,
            BigtableVersion? version = null)
        {
            var family = row.Families.SingleOrDefault();
            Assert.NotNull(family);
            Assert.Equal(familyName, family.Name);
            
            var column = family?.Columns.SingleOrDefault();
            Assert.NotNull(column);
            Assert.Equal(columnQualifier.Value, column.Qualifier);

            var cell = column.Cells.SingleOrDefault();
            Assert.NotNull(cell);
            Assert.Equal(value.Value, cell.Value);
            if (version != null)
            {
                Assert.Equal(version.Value.Micros, cell.TimestampMicros);
            }
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
            bool hasValue = await HasValueHelperAsync(
                client,
                tableName,
                rowKey,
                familyName,
                columnQualifier,
                value,
                version);
            Assert.False(hasValue);
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
            bool hasValue = await HasValueHelperAsync(
                client,
                tableName,
                rowKey,
                familyName,
                columnQualifier,
                value,
                version);
            Assert.True(hasValue);
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
            var row = await client.ReadRowAsync(tableName, rowKey);
            Assert.Equal(rowKey.Value, row.Key);

            var cells = row
                .Families.SingleOrDefault(f => f.Name == familyName)
                ?.Columns.SingleOrDefault(c => c.Qualifier == columnQualifier)
                ?.Cells;
            var cell = version != null
                ? cells?.SingleOrDefault(c => c.TimestampMicros == version.Value.Micros)
                : cells?.SingleOrDefault();
            return cell != null && cell.Value == value;
        }
    }
}
