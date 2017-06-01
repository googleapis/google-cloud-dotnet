// Copyright 2017 Google Inc. All Rights Reserved.
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

#region

using System;
using System.Threading.Tasks;
using Xunit;

#endregion

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    public class BindingTests : IClassFixture<TestDatabaseFixture>
    {
        public BindingTests(TestDatabaseFixture testFixture)
        {
            _testFixture = testFixture;
        }

        private readonly TestDatabaseFixture _testFixture;

        async Task TestBind<T>(SpannerDbType parameterType, T value)
        {
            // ReSharper disable once RedundantAssignment
            int rowsRead = -1;
            T valueRead = default(T);

            using (var connection = await _testFixture.GetTestDatabaseConnectionAsync())
            {
                var cmd = connection.CreateSelectCommand("SELECT @v",
                    new SpannerParameterCollection {new SpannerParameter("v", parameterType)});

                cmd.Parameters["v"].Value = value;
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    rowsRead = 0;
                    while (await reader.ReadAsync())
                    {
                        valueRead = reader.GetFieldValue<T>(0);
                        rowsRead++;
                    }
                }
            }
            Assert.Equal(rowsRead, 1);
            Array valueAsArray = value as Array;
            if (valueAsArray != null)
            {
                Array valueReadAsArray = valueRead as Array;
                Assert.NotNull(valueReadAsArray);
                for (int i = 0; i < valueAsArray.Length; i++)
                {
                    // ReSharper disable once PossibleNullReferenceException
                    Assert.Equal(valueReadAsArray.GetValue(i), valueAsArray.GetValue(i));
                }
            } else
            {
                Assert.Equal(valueRead, value);
            }
        }

        [Fact]
        public Task BindBoolean() => TestBind(SpannerDbType.Bool, true);

        [Fact]
        public Task BindBooleanArray() => TestBind(
            SpannerDbType.ArrayOf(SpannerDbType.Bool),
            new bool?[] {true, null, false});

        [Fact]
        public Task BindBooleanEmptyArray() => TestBind(
            SpannerDbType.ArrayOf(SpannerDbType.Bool),
            new bool[] { });

        [Fact]
        public Task BindBooleanNull() => TestBind<bool?>(SpannerDbType.Bool, null);

        [Fact]
        public Task BindBooleanNullArray() =>
            TestBind<bool[]>(SpannerDbType.Bool, null);

        [Fact]
        public Task BindByteArray() => TestBind(SpannerDbType.Bytes,
            new byte[] {1, 2, 3});

        [Fact]
        public Task BindByteArrayNull() => TestBind<byte[]>(SpannerDbType.Bytes, null);

        [Fact]
        public Task BindDate() => TestBind(SpannerDbType.Date,
            new DateTime(2017, 5, 26));

        [Fact]
        public Task BindDateArray() => TestBind(
            SpannerDbType.ArrayOf(SpannerDbType.Date),
            new DateTime?[] {new DateTime(2017, 5, 26), null, new DateTime(2017, 5, 9),});

        [Fact]
        public Task BindDateEmptyArray() => TestBind(
            SpannerDbType.ArrayOf(SpannerDbType.Date),
            new DateTime?[] { });

        [Fact]
        public Task BindDateNull() => TestBind<DateTime?>(SpannerDbType.Date, null);

        [Fact]
        public Task BindDateNullArray() => TestBind<DateTime?[]>(
            SpannerDbType.ArrayOf(SpannerDbType.Date),
            null);

        [Fact]
        public Task BindFloat64() => TestBind(SpannerDbType.Float64, 1.0);

        [Fact]
        public Task BindFloat64Array() => TestBind(
            SpannerDbType.ArrayOf(SpannerDbType.Float64),
            new double?[] {0.0, null, 1.0});

        [Fact]
        public Task BindFloat64EmptyArray() => TestBind(
            SpannerDbType.ArrayOf(SpannerDbType.Float64),
            new double[] { });

        [Fact]
        public Task BindFloat64Null() => TestBind<double?>(SpannerDbType.Float64, null);

        [Fact]
        public Task BindFloat64NullArray() => TestBind<double[]>(
            SpannerDbType.ArrayOf(SpannerDbType.Float64),
            null);

        [Fact]
        public Task BindInt64() => TestBind(SpannerDbType.Int64, (long) 1);

        [Fact]
        public Task BindInt64Array() => TestBind(
            SpannerDbType.ArrayOf(SpannerDbType.Int64),
            new long?[] {1, null, 0});

        [Fact]
        public Task BindInt64EmptyArray() => TestBind(
            SpannerDbType.ArrayOf(SpannerDbType.Int64),
            new long[] { });

        [Fact]
        public Task BindInt64Null() => TestBind<long?>(SpannerDbType.Int64, null);

        [Fact]
        public Task BindInt64NullArray() => TestBind<long[]>(
            SpannerDbType.ArrayOf(SpannerDbType.Int64),
            null);

        [Fact]
        public Task BindString() => TestBind(SpannerDbType.String, "abc");

        [Fact]
        public Task BindStringArray() => TestBind(
            SpannerDbType.ArrayOf(SpannerDbType.String),
            new[] {"abc", null, "123"});

        [Fact]
        public Task BindStringEmptyArray() => TestBind(
            SpannerDbType.ArrayOf(SpannerDbType.String),
            new string[] { });

        [Fact]
        public Task BindStringNull() => TestBind<string>(SpannerDbType.String, null);

        [Fact]
        public Task BindStringNullArray() => TestBind<string[]>(
            SpannerDbType.ArrayOf(SpannerDbType.String),
            null);

        [Fact]
        public Task BindTimestamp() => TestBind(SpannerDbType.Timestamp,
            new DateTime(2017, 5, 26, 15, 0, 0));

        [Fact]
        public Task BindTimestampArray() => TestBind(
            SpannerDbType.ArrayOf(SpannerDbType.Timestamp),
            new DateTime?[]
                {new DateTime(2017, 5, 26, 3, 15, 0), null, new DateTime(2017, 5, 9, 12, 30, 0)});

        [Fact]
        public Task BindTimestampEmptyArray() => TestBind(
            SpannerDbType.ArrayOf(SpannerDbType.Timestamp),
            new DateTime?[] { });

        [Fact]
        public Task BindTimestampNull() => TestBind<DateTime?>(SpannerDbType.Timestamp,
            null);

        [Fact]
        public Task BindTimestampNullArray() => TestBind<DateTime?[]>(
            SpannerDbType.ArrayOf(SpannerDbType.Timestamp),
            null);
    }
}