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
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Google.Cloud.BigQuery.V2.Tests
{
    public class BigQueryRowTest
    {
        [Fact]
        public void Scalars()
        {
            var schema = new TableSchemaBuilder
            {
                { "integer", BigQueryDbType.Int64 },
                { "bool", BigQueryDbType.Bool },
                { "bytes", BigQueryDbType.Bytes },
                { "float", BigQueryDbType.Float64 },
                { "string", BigQueryDbType.String },
                { "timestamp", BigQueryDbType.Timestamp },
                { "date", BigQueryDbType.Date },
                { "dateTime", BigQueryDbType.DateTime },
                { "time", BigQueryDbType.Time },
                { "numeric", BigQueryDbType.Numeric },
                { "bigNumeric", BigQueryDbType.BigNumeric },
                { "geography", BigQueryDbType.Geography },
                { "struct", new TableSchemaBuilder { { "x", BigQueryDbType.Int64 }, { "y", BigQueryDbType.String } } }
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
                    new TableCell { V = "2017-08-09" },
                    new TableCell { V = "2017-08-09T12:34:56.123" },
                    new TableCell { V = "12:34:56.123" },
                    new TableCell { V = "1234567890123456789012345678.123456789" },
                    new TableCell { V = "123456789012345678901234567890123456789.12345678901234567890123456789012345678" },
                    new TableCell { V = "POINT(1 2)" },
                    new TableCell { V = new JObject { ["f"] = new JArray {new JObject { ["v"] = "100" }, new JObject { ["v"] = "xyz" } } } }
                }
            };
            var row = new BigQueryRow(rawRow, schema);
            Assert.Equal(10, (long)row["integer"]);
            Assert.Equal(true, (bool)row["bool"]);
            Assert.Equal(new byte[] { 1, 2 }, (byte[])row["bytes"]);
            Assert.Equal(2.5d, (double)row["float"]);
            Assert.Equal("text", (string)row["string"]);
            Assert.Equal(new DateTime(2016, 10, 27, 11, 9, 40, 500, DateTimeKind.Utc), (DateTime)row["timestamp"]);
            Assert.Equal(new DateTime(2017, 8, 9, 0, 0, 0, DateTimeKind.Utc), (DateTime)row["date"]);
            Assert.Equal(new DateTime(2017, 8, 9, 12, 34, 56, 123, DateTimeKind.Utc), (DateTime)row["dateTime"]);
            Assert.Equal(new TimeSpan(0, 12, 34, 56, 123), (TimeSpan)row["time"]);
            Assert.Equal(BigQueryNumeric.Parse("1234567890123456789012345678.123456789"), (BigQueryNumeric) row["numeric"]);
            Assert.Equal(BigQueryBigNumeric.Parse("123456789012345678901234567890123456789.12345678901234567890123456789012345678"), (BigQueryBigNumeric)row["bigNumeric"]);
            Assert.Equal(BigQueryGeography.Parse("POINT(1 2)"), (BigQueryGeography) row["geography"]);
            Assert.Equal(new Dictionary<string, object> { { "x", 100L }, { "y", "xyz" } }, (Dictionary<string, object>)row["struct"]);
        }

        [Fact]
        public void Arrays()
        {
            var schema = new TableSchemaBuilder
            {
                { "integer", BigQueryDbType.Int64, BigQueryFieldMode.Repeated },
                { "bool", BigQueryDbType.Bool, BigQueryFieldMode.Repeated },
                { "bytes", BigQueryDbType.Bytes, BigQueryFieldMode.Repeated },
                { "float", BigQueryDbType.Float64, BigQueryFieldMode.Repeated },
                { "string", BigQueryDbType.String, BigQueryFieldMode.Repeated },
                { "timestamp", BigQueryDbType.Timestamp, BigQueryFieldMode.Repeated },
                { "date", BigQueryDbType.Date, BigQueryFieldMode.Repeated },
                { "dateTime", BigQueryDbType.DateTime, BigQueryFieldMode.Repeated },
                { "time", BigQueryDbType.Time, BigQueryFieldMode.Repeated },
                { "numeric", BigQueryDbType.Numeric, BigQueryFieldMode.Repeated },
                { "bigNumeric", BigQueryDbType.BigNumeric, BigQueryFieldMode.Repeated },
                { "geography", BigQueryDbType.Geography, BigQueryFieldMode.Repeated },
                { "struct", new TableSchemaBuilder { { "x", BigQueryDbType.Int64 }, { "y", BigQueryDbType.String } }, BigQueryFieldMode.Repeated }
            }.Build();
            var rawRow = new TableRow
            {
                F = new[]
                {
                    new TableCell { V = CreateArray("10", "20") },
                    new TableCell { V = CreateArray("true", "false") },
                    new TableCell { V = CreateArray("AQI=", "AQM=") }, // [1, 2], [1, 3]
                    new TableCell { V = CreateArray("2.5", "3.5") },
                    new TableCell { V = CreateArray("text", "more text") },
                    new TableCell { V = CreateArray("1477566580.5", "1477566581.5") }, // 2016-10-27T11:09:40.500Z, 2016-10-27T11:09:41.500Z
                    new TableCell { V = CreateArray("2017-08-09", "2017-08-10") },
                    new TableCell { V = CreateArray("2017-08-09T12:34:56.123","2017-08-09T12:34:57.123") },
                    new TableCell { V = CreateArray("12:34:56.123", "12:34:57.123") },
                    new TableCell { V = CreateArray("1234567890123456789012345678.123456789", "0.000000001") },
                    new TableCell { V = CreateArray("123456789012345678901234567890123456789.12345678901234567890123456789012345678", "0.00000000000000000000000000000000000001") },
                    new TableCell { V = CreateArray("POINT(1 3)", "POINT(2 4)") },
                    new TableCell { V = new JArray {
                        new JObject { ["v"] = new JObject { ["f"] = new JArray { new JObject { ["v"] = "100" }, new JObject { ["v"] = "xyz" } } } },
                        new JObject { ["v"] = new JObject { ["f"] = new JArray { new JObject { ["v"] = "200" }, new JObject { ["v"] = "abc" } } } }
                    } }
                }
            };
            var row = new BigQueryRow(rawRow, schema);
            Assert.Equal(new[] { 10L, 20L }, (long[])row["integer"]);
            Assert.Equal(new[] { true, false }, (bool[])row["bool"]);
            Assert.Equal(new[] { new byte[] { 1, 2 }, new byte[] { 1, 3 } }, (byte[][])row["bytes"]);
            Assert.Equal(new[] { 2.5d, 3.5d }, (double[])row["float"]);
            Assert.Equal(new[] { "text", "more text" }, (string[])row["string"]);
            Assert.Equal(new[] { new DateTime(2016, 10, 27, 11, 9, 40, 500, DateTimeKind.Utc), new DateTime(2016, 10, 27, 11, 9, 41, 500, DateTimeKind.Utc) },
                (DateTime[])row["timestamp"]);
            Assert.Equal(new[] { new DateTime(2017, 8, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2017, 8, 10, 0, 0, 0, DateTimeKind.Utc) },
                (DateTime[])row["date"]);
            Assert.Equal(new[] { new DateTime(2017, 8, 9, 12, 34, 56, 123, DateTimeKind.Utc), new DateTime(2017, 8, 9, 12, 34, 57, 123, DateTimeKind.Utc) },
                (DateTime[])row["dateTime"]);
            Assert.Equal(new[] { new TimeSpan(0, 12, 34, 56, 123), new TimeSpan(0, 12, 34, 57, 123) }, (TimeSpan[])row["time"]);
            Assert.Equal(new[] { BigQueryNumeric.Parse("1234567890123456789012345678.123456789"), BigQueryNumeric.Parse("0.000000001") }, (BigQueryNumeric[]) row["numeric"]);
            Assert.Equal(new[] { BigQueryBigNumeric.Parse("123456789012345678901234567890123456789.12345678901234567890123456789012345678"), BigQueryBigNumeric.Parse("0.00000000000000000000000000000000000001") }, (BigQueryBigNumeric[])row["bigNumeric"]);
            Assert.Equal(new[] { BigQueryGeography.Parse("POINT(1 3)"), BigQueryGeography.Parse("POINT(2 4)") }, (BigQueryGeography[]) row["geography"]);
            Assert.Equal(new[]
                {
                    new Dictionary<string, object> { { "x", 100L }, { "y", "xyz" } },
                    new Dictionary<string, object> { { "x", 200L }, { "y", "abc" } }
                },
                (Dictionary<string, object>[])row["struct"]);
        }

        [Fact]
        public void Null()
        {
            var schema = new TableSchemaBuilder
            {
                { "text", BigQueryDbType.String },
            }.Build();
            var rawRow = new TableRow
            {
                F = new[]
                {
                    new TableCell { V = null }
                }
            };
            var row = new BigQueryRow(rawRow, schema);
            Assert.Null(row["text"]);
        }

        [Fact]
        public void RecordWrongFieldCount()
        {
            var schema = new TableSchemaBuilder
            {
                { "struct", new TableSchemaBuilder { { "x", BigQueryDbType.Int64 }, { "y", BigQueryDbType.String } } }
            }.Build();
            var rawRow = new TableRow
            {
                F = new[]
                {
                    // No value for y
                    new TableCell { V = new JObject { ["f"] = new JArray {new JObject { ["v"] = "100" } } } }
                }
            };
            var row = new BigQueryRow(rawRow, schema);
            Assert.Throws<InvalidOperationException>(() => row["struct"]);
        }

        public static IEnumerable<object[]> TimestampRoundingData
        {
            get
            {
                yield return new object[] { "1.090855528173333E9", new DateTime(2004, 7, 26, 15, 25, 28, DateTimeKind.Utc).AddTicks(1733330) };
                yield return new object[] { "-2.2089924E9", new DateTime(1899, 12, 31, 23, 0, 0, 0, DateTimeKind.Utc) };
            }
        }

        [Theory]
        [MemberData(nameof(TimestampRoundingData))]
        public void TimestampRounding(string rawValue, DateTime expected)
        {
            var schema = new TableSchemaBuilder
            {
                { "timestamp", BigQueryDbType.Timestamp },
            }.Build();
            var rawRow = new TableRow
            {
                F = new[]
                {
                    new TableCell { V = rawValue },
                }
            };
            var row = new BigQueryRow(rawRow, schema);
            Assert.Equal(expected, (DateTime) row["timestamp"]);
        }

        private JArray CreateArray(params string[] values) => new JArray(values.Select(CreateObject));

        private JObject CreateObject(string value) => new JObject { ["v"] = value };
    }
}
