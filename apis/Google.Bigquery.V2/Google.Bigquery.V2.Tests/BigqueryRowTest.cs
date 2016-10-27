// Copyright 2016 Google Inc. All Rights Reserved.
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

using Google.Apis.Bigquery.v2.Data;
using System;
using Xunit;

namespace Google.Bigquery.V2.Tests
{
    public class BigqueryRowTest
    {
        [Fact]
        public void Scalars()
        {
            var schema = new TableSchemaBuilder
            {
                { "integer", BigqueryDbType.Integer },
                { "bool", BigqueryDbType.Boolean },
                { "bytes", BigqueryDbType.Bytes },
                { "float", BigqueryDbType.Float },
                { "string", BigqueryDbType.String },
                { "timestamp", BigqueryDbType.Timestamp },
            }.Build();
            var rawRow = new TableRow
            {
                F = new[]
                {
                    new TableCell { V = "10" },
                    new TableCell { V = "true" },
                    new TableCell { V = "AQI=" }, // 1, 2
                    new TableCell { V = "2.5" },
                    new TableCell { V = "text" },
                    new TableCell { V = "1477566580.5" }, // 2016-10-27T11:09:40.500Z
                }
            };
            var row = new BigqueryRow(rawRow, schema);
            Assert.Equal(10, (long)row["integer"]);
            Assert.Equal(true, (bool)row["bool"]);
            Assert.Equal(new byte[] { 1, 2 }, (byte[])row["bytes"]);
            Assert.Equal(2.5d, (double)row["float"]);
            Assert.Equal("text", (string)row["string"]);
            Assert.Equal(new DateTime(2016, 10, 27, 11, 9, 40, 500, DateTimeKind.Utc), (DateTime)row["timestamp"]);
        }
    }
}
