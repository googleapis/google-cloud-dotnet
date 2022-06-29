// Copyright 2021 Google LLC
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

using Google.Cloud.Spanner.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [Collection(nameof(DateTimestampTableFixture))]
    [CommonTestDiagnostics]
    public class DateTimestampReadTests
    {
        private readonly DateTimestampTableFixture _fixture;

        public DateTimestampReadTests(DateTimestampTableFixture fixture) =>
            _fixture = fixture;

        private static bool[] s_readWriteAsDateTime = new[]
        {
            true,
            false
        };

        public static IEnumerable<object[]> TestDates =>
            new List<object[]>
            {
                new object[] { new DateTime(2020, 9, 29) },
                new object[] { DateTime.SpecifyKind(new DateTime(2020, 10, 29), DateTimeKind.Utc) },
                new object[] { DateTime.SpecifyKind(new DateTime(2020, 11, 29), DateTimeKind.Local) },
                new object[] { new DateTime(2020, 12, 29, 0, 0, 0, DateTimeKind.Utc) },
                new object[] { new DateTime(2020, 12, 29, 0, 0, 0, DateTimeKind.Local) },
                new object[] { new DateTime(2020, 12, 29, 0, 0, 0, DateTimeKind.Local) },
            };

        public static IEnumerable<object[]> TestDatesWithReadWriteTypes() =>
            from writeAsDateTime in s_readWriteAsDateTime
            from readAsDateTime in s_readWriteAsDateTime
            from parameters in TestDates
            select new object[] { writeAsDateTime, readAsDateTime }.Concat(parameters).ToArray();

        [Theory]
        [MemberData(nameof(TestDates))]
        public async Task WriteDateThenRead_ShouldBeEqual(DateTime expectedDate)
        {
            using var connection = _fixture.GetConnection();
            // Write the date value and read it back.
            await connection.CreateInsertOrUpdateCommand(_fixture.TableName,
                new SpannerParameterCollection
                {
                        new SpannerParameter("DateValue", SpannerDbType.Date, expectedDate),
                }
            ).ExecuteNonQueryAsync();
            var dbDate = await connection.CreateSelectCommand($"SELECT DateValue FROM {_fixture.TableName}").ExecuteScalarAsync<DateTime>();
            Assert.Equal(expectedDate, dbDate);
        }

        /// <summary>
        /// Writes the date then reads it using DateTime or SpannerDate based on parameters and validates that
        /// values are equal.
        /// </summary>
        /// <param name="writeAsDateTime">if set to <c>true</c> <see cref="DateTime"/> is used to write the data, else <see cref="SpannerDate"/> is used.</param>
        /// <param name="readAsDateTime">if set to <c>true</c> <see cref="DateTime"/> is used to read the data, else <see cref="SpannerDate"/> is used.</param>
        /// <param name="expectedDate">The expected date.</param>
        [Theory]
        [MemberData(nameof(TestDatesWithReadWriteTypes))]
        public async Task WriteDateThenRead_ShouldBeEqual_UseSpannerDateAndDateTime(bool writeAsDateTime, 
            bool readAsDateTime, 
            DateTime expectedDate)
        {
            // Adding a new SpannerDate type in backward compatible fashion.
            // We could write date as SpannerDate and read as DateTime or 
            // write date as DateTime and read as SpannerDate. This is in addition to
            // write date as DateTime and read as DateTime or,
            // write date as SpannerDate and read as SpannerDate.
            using var connection = _fixture.GetConnection();
            // Write the date value and read it back.
            await connection.CreateInsertOrUpdateCommand(_fixture.TableName,
                writeAsDateTime ?
                new SpannerParameterCollection
                {
                        new SpannerParameter("DateValue", SpannerDbType.Date, expectedDate)
                }
                : new SpannerParameterCollection
                {
                        new SpannerParameter("DateValue", SpannerDbType.Date, SpannerDate.FromDateTime(expectedDate))
                }
            ).ExecuteNonQueryAsync();

            if (readAsDateTime)
            {
                var dbDate = await connection.CreateSelectCommand($"SELECT DateValue FROM {_fixture.TableName}").ExecuteScalarAsync<DateTime>();
                Assert.Equal(expectedDate, dbDate);
            }
            else
            {
                var dbDate = await connection.CreateSelectCommand($"SELECT DateValue FROM {_fixture.TableName}").ExecuteScalarAsync<SpannerDate>();
                Assert.Equal(SpannerDate.FromDateTime(expectedDate), dbDate);
            }
        }

        public static IEnumerable<object[]> TestTimestamps =>
            new List<object[]>
            {
                new object[] { new DateTime(2020, 9, 29, 18, 51, 10) },
                new object[] { DateTime.SpecifyKind(new DateTime(2020, 10, 29, 18, 51, 10), DateTimeKind.Utc) },
                new object[] { DateTime.SpecifyKind(new DateTime(2020, 11, 29, 18, 51, 10), DateTimeKind.Local) },
                new object[] { new DateTime(2020, 10, 29, 18, 51, 10, DateTimeKind.Utc) },
                new object[] { new DateTime(2020, 11, 29, 18, 51, 10, DateTimeKind.Local) },
            };

        [Theory]
        [MemberData(nameof(TestTimestamps))]
        public async Task WriteTimestampThenRead_ShouldBeEqual(DateTime expectedTimestamp)
        {
            using (var connection = _fixture.GetConnection())
            {
                // Write the timestamp value and read it back.
                await connection.CreateInsertOrUpdateCommand(_fixture.TableName,
                    new SpannerParameterCollection
                    {
                        new SpannerParameter("TimestampValue", SpannerDbType.Timestamp, expectedTimestamp),
                    }
                ).ExecuteNonQueryAsync();
                var dbTimestamp = await connection.CreateSelectCommand($"SELECT TimestampValue FROM {_fixture.TableName}").ExecuteScalarAsync<DateTime>();
                // Cloud Spanner always stores the timestamp in UTC, so if the original input value was
                // a local time, we need to convert the value that we read in the database back to local time.
                if (expectedTimestamp.Kind == DateTimeKind.Local)
                {
                    dbTimestamp = dbTimestamp.ToLocalTime();
                }
                Assert.Equal(expectedTimestamp, dbTimestamp);
            }
        }
    }
}
