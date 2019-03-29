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
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [Collection(nameof(AllTypesTableFixture))]
    [CommonTestDiagnostics]
    public class GetSchemaTableTests
    {
        private readonly AllTypesTableFixture _fixture;

        public GetSchemaTableTests(AllTypesTableFixture fixture) => _fixture = fixture;

        [Fact]
        public async Task GetSchemaTable_Default_ReturnsNull()
        {
            using (var connection = _fixture.GetConnection())
            {
                var command = connection.CreateSelectCommand($"SELECT Int64Value, BytesArrayValue FROM {_fixture.TableName}");
                using (var reader = await command.ExecuteReaderAsync())
                {
                    Assert.Null(reader.GetSchemaTable());
                }
            }
        }

        [Fact]
        public async Task GetSchemaTable_WithFlagEnabled_ReturnsNull()
        {
            using (var connection = new SpannerConnection($"{_fixture.ConnectionString};EnableGetSchemaTable=true"))
            {
                var command = connection.CreateSelectCommand($"SELECT Int64Value, BytesArrayValue FROM {_fixture.TableName}");
                using (var reader = await command.ExecuteReaderAsync())
                {
                    var table = reader.GetSchemaTable();
                    Assert.Equal(2, table.Rows.Count);

                    var int64ValueRow = table.Rows[0];
                    Assert.Equal("Int64Value", (string) int64ValueRow["ColumnName"]);
                    Assert.Equal(0, (int) int64ValueRow["ColumnOrdinal"]);
                    Assert.Equal(typeof(long), (System.Type) int64ValueRow["DataType"]);
                    Assert.Equal(SpannerDbType.Int64, (SpannerDbType) int64ValueRow["ProviderType"]);
                    Assert.True(int64ValueRow.IsNull("ColumnSize"));
                    Assert.True(int64ValueRow.IsNull("NumericPrecision"));
                    Assert.True(int64ValueRow.IsNull("NumericScale"));

                    var bytesArrayValueRow = table.Rows[1];
                    Assert.Equal("BytesArrayValue", (string) bytesArrayValueRow["ColumnName"]);
                    Assert.Equal(1, (int) bytesArrayValueRow["ColumnOrdinal"]);
                    Assert.Equal(typeof(List<byte[]>), (System.Type) bytesArrayValueRow["DataType"]);
                    Assert.Equal(SpannerDbType.ArrayOf(SpannerDbType.Bytes), (SpannerDbType) bytesArrayValueRow["ProviderType"]);
                    Assert.True(bytesArrayValueRow.IsNull("ColumnSize"));
                    Assert.True(bytesArrayValueRow.IsNull("NumericPrecision"));
                    Assert.True(bytesArrayValueRow.IsNull("NumericScale"));
                }
            }
        }
    }
}
