using System;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    public class BindingTests : IClassFixture<TestDatabaseFixture>
    {
        private readonly TestDatabaseFixture _testFixture;

        public BindingTests(TestDatabaseFixture testFixture)
        {
            _testFixture = testFixture;
        }

        [Fact]
        public async Task TestBindBoolean() => 
            await TestBind(SpannerDbType.Bool, true);
        [Fact]
        public async Task TestBindBooleanNull() =>
            await TestBind<bool?>(SpannerDbType.Bool, null);
        [Fact]
        public async Task TestBindBooleanArray() =>
            await TestBind(SpannerDbType.ArrayOf(SpannerDbType.Bool), new bool?[] {true, null, false});
        [Fact]
        public async Task TestBindBooleanEmptyArray() =>
            await TestBind(SpannerDbType.ArrayOf(SpannerDbType.Bool), new bool[] { });
        [Fact]
        public async Task TestBindBooleanNullArray() =>
            await TestBind<bool[]>(SpannerDbType.Bool, null);

        [Fact]
        public async Task TestBindInt64() =>
            await TestBind(SpannerDbType.Int64, (long)1);
        [Fact]
        public async Task TestBindInt64Null() =>
            await TestBind<long?>(SpannerDbType.Int64, null);
        [Fact]
        public async Task TestBindInt64Array() =>
            await TestBind(SpannerDbType.ArrayOf(SpannerDbType.Int64), new long?[] { 1, null, 0});
        [Fact]
        public async Task TestBindInt64EmptyArray() =>
            await TestBind(SpannerDbType.ArrayOf(SpannerDbType.Int64), new long[] { });
        [Fact]
        public async Task TestBindInt64NullArray() =>
            await TestBind<long[]>(SpannerDbType.ArrayOf(SpannerDbType.Int64), null);

        [Fact]
        public async Task TestBindFloat64() =>
            await TestBind(SpannerDbType.Float64, 1.0);
        [Fact]
        public async Task TestBindFloat64Null() =>
            await TestBind<double?>(SpannerDbType.Float64, null);
        [Fact]
        public async Task TestBindFloat64Array() =>
            await TestBind(SpannerDbType.ArrayOf(SpannerDbType.Float64), new double?[] {0.0, null, 1.0});
        [Fact]
        public async Task TestBindFloat64EmptyArray() =>
            await TestBind(SpannerDbType.ArrayOf(SpannerDbType.Float64), new double[] {});
        [Fact]
        public async Task TestBindFloat64NullArray() =>
            await TestBind<double[]>(SpannerDbType.ArrayOf(SpannerDbType.Float64), null);

        [Fact]
        public async Task TestBindString() =>
            await TestBind(SpannerDbType.String, "abc");
        [Fact]
        public async Task TestBindStringNull() =>
            await TestBind<double?>(SpannerDbType.String, null);
        [Fact]
        public async Task TestBindStringArray() =>
            await TestBind(SpannerDbType.ArrayOf(SpannerDbType.String), new[]
                { "abc", null, "123"});
        [Fact]
        public async Task TestBindStringEmptyArray() =>
            await TestBind(SpannerDbType.ArrayOf(SpannerDbType.String), new string[] {});
        [Fact]
        public async Task TestBindStringNullArray() =>
            await TestBind<string[]>(SpannerDbType.ArrayOf(SpannerDbType.String), null);

        [Fact]
        public async Task TestBindByteArray() =>
            await TestBind(SpannerDbType.Bytes, new byte[] { 1, 2, 3 });
        [Fact]
        public async Task TestBindByteArrayNull() =>
            await TestBind<double?>(SpannerDbType.Bytes, null);

        [Fact]
        public async Task TestBindDate() =>
            await TestBind(SpannerDbType.Date, new DateTime(2017, 5, 26));
        [Fact]
        public async Task TestBindDateNull() =>
            await TestBind<double?>(SpannerDbType.Date, null);
        [Fact]
        public async Task TestBindDateArray() =>
            await TestBind(SpannerDbType.ArrayOf(SpannerDbType.Date), new DateTime?[]
            {
                new DateTime(2017, 5, 26),
                null,
                new DateTime(2017, 5, 9),
            });
        [Fact]
        public async Task TestBindDateEmptyArray() =>
            await TestBind(SpannerDbType.ArrayOf(SpannerDbType.Date), new DateTime?[]
              {});
        [Fact]
        public async Task TestBindDateNullArray() =>
            await TestBind<DateTime?[]>(SpannerDbType.ArrayOf(SpannerDbType.Date), null);

        [Fact]
        public async Task TestBindTimestamp() =>
            await TestBind(SpannerDbType.Timestamp, new DateTime(2017, 5, 26, 15, 0, 0));
        [Fact]
        public async Task TestBindTimestampNull() =>
            await TestBind<double?>(SpannerDbType.Timestamp, null);
        [Fact]
        public async Task TestBindTimestampArray() =>
            await TestBind(SpannerDbType.ArrayOf(SpannerDbType.Timestamp), new DateTime?[]
            {
                new DateTime(2017, 5, 26, 3, 15, 0),
                null,
                new DateTime(2017, 5, 9, 12, 30, 0)
            });
        [Fact]
        public async Task TestBindTimestampEmptyArray() =>
            await TestBind(SpannerDbType.ArrayOf(SpannerDbType.Timestamp), new DateTime?[]
                {});
        [Fact]
        public async Task TestBindTimestampNullArray() =>
            await TestBind<DateTime?[]>(SpannerDbType.ArrayOf(SpannerDbType.Timestamp), null);

        async Task TestBind<T>(SpannerDbType parameterType, T value)
        {
            // ReSharper disable once RedundantAssignment
            int rowsRead = -1;
            T valueRead = default(T);

            using (var connection = await _testFixture.GetTestDatabaseConnectionAsync())
            {
                var cmd =
                    connection.CreateSelectCommand("SELECT @v", new SpannerParameterCollection
                    {
                        new SpannerParameter("v", parameterType)
                    });

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
            Assert.True(rowsRead == 1);
            Array valueAsArray = value as Array;
            if (valueAsArray != null)
            {
                Array valueReadAsArray = valueRead as Array;
                Assert.True(valueReadAsArray != null);
                for (int i = 0; i < valueAsArray.Length; i++)
                {
                    // ReSharper disable once PossibleNullReferenceException
                    Assert.True(Equals(valueReadAsArray.GetValue(i), valueAsArray.GetValue(i)));
                }
            }
            else
            {
                Assert.True(Equals(valueRead, value));
            }
        }
    }
}
