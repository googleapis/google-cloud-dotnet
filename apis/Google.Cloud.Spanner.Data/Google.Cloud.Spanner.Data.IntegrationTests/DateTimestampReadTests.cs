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

        public static IEnumerable<object[]> TestDates =>
            new List<object[]>
            {
                new object[] { new SpannerDate(2020, 9, 29) },
                new object[] { new SpannerDate(DateTime.SpecifyKind(new DateTime(2020, 10, 29), DateTimeKind.Utc)) },
                new object[] { new SpannerDate(DateTime.SpecifyKind(new DateTime(2020, 11, 29), DateTimeKind.Local)) },
                new object[] { new SpannerDate(new DateTime(2020, 12, 29, 0, 0, 0, DateTimeKind.Utc)) },
                new object[] { new SpannerDate(new DateTime(2020, 12, 29, 0, 0, 0, DateTimeKind.Local)) },
                new object[] { new SpannerDate(new DateTime(2020, 12, 29, 0, 0, 0, DateTimeKind.Local)) },
            };

        [Theory]
        [MemberData(nameof(TestDates))]
        public async void WriteDateThenRead_ShouldBeEqual(SpannerDate expectedDate)
        {
            using var connection = _fixture.GetConnection();
            // Write the date value and read it back.
            await connection.CreateInsertOrUpdateCommand(_fixture.TableName,
                new SpannerParameterCollection
                {
                        new SpannerParameter("DateValue", SpannerDbType.Date, expectedDate),
                }
            ).ExecuteNonQueryAsync();
            var dbDate = await connection.CreateSelectCommand($"SELECT DateValue FROM {_fixture.TableName}").ExecuteScalarAsync<SpannerDate>();
            Assert.Equal(expectedDate, dbDate);
        }

        [Theory]
        [MemberData(nameof(TestDates))]
        public async void WriteDateThenRead_ShouldBeEqual_UseDateTime(SpannerDate expectedDate)
        {
            // Set UseDateTimeForDate=true, to use DateTime. Default value is false, so SpannerDate is used by default.
            using var connection = new SpannerConnection($"{_fixture.ConnectionString};{nameof(SpannerConnectionStringBuilder.UseDateTimeForDate)}=true");
            // Write the date value and read it back.
            await connection.CreateInsertOrUpdateCommand(_fixture.TableName,
                new SpannerParameterCollection
                {
                        // Provide value as DateTime.
                        new SpannerParameter("DateValue", SpannerDbType.Date, expectedDate.ToDateTime()),
                }
            ).ExecuteNonQueryAsync();
            // Read value as DateTime.
            var dbDate = await connection.CreateSelectCommand($"SELECT DateValue FROM {_fixture.TableName}").ExecuteScalarAsync<DateTime>();
            Assert.Equal(expectedDate.ToDateTime(), dbDate);
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
        public async void WriteTimestampThenRead_ShouldBeEqual(DateTime expectedTimestamp)
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
