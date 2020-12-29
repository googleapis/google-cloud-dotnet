// Copyright 2020 Google LLC
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

using System;
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

        [Fact]
        public async void WriteDateThenRead_ShouldBeEqual()
        {
            using (var connection = _fixture.GetConnection())
            {
                foreach (var date in new DateTime[] {
                    new DateTime(2020, 9, 29),
                    DateTime.SpecifyKind(new DateTime(2020, 10, 29), DateTimeKind.Utc),
                    DateTime.SpecifyKind(new DateTime(2020, 11, 29), DateTimeKind.Local),
                    new DateTime(2020, 12, 29, 0, 0, 0, DateTimeKind.Utc),
                    new DateTime(2020, 12, 29, 0, 0, 0, DateTimeKind.Local),
                    DateTime.Today,
                })
                {
                    // Write the date value and read it back.
                    await connection.CreateInsertOrUpdateCommand(_fixture.TableName,
                        new SpannerParameterCollection
                        {
                            new SpannerParameter("DateValue", SpannerDbType.Date, date),
                        }
                    ).ExecuteNonQueryAsync();
                    using (var reader = await connection.CreateSelectCommand($"SELECT DateValue FROM {_fixture.TableName}").ExecuteReaderAsync())
                    {
                        Assert.True(await reader.ReadAsync());
                        Assert.Equal(date, reader.GetFieldValue<DateTime>("DateValue"));
                        Assert.False(await reader.ReadAsync());
                    }
                }
            }
        }

        [Fact]
        public async void WriteTimestampThenRead_ShouldBeEqual()
        {
            using (var connection = _fixture.GetConnection())
            {
                foreach (var timestamp in new DateTime[] {
                    new DateTime(2020, 9, 29, 18, 51, 10),
                    DateTime.SpecifyKind(new DateTime(2020, 10, 29, 18, 51, 10), DateTimeKind.Utc),
                    DateTime.SpecifyKind(new DateTime(2020, 11, 29, 18, 51, 10), DateTimeKind.Local),
                    new DateTime(2020, 10, 29, 18, 51, 10, DateTimeKind.Utc),
                    new DateTime(2020, 11, 29, 18, 51, 10, DateTimeKind.Local),
                    DateTime.Now,
                    DateTime.UtcNow,
                })
                {
                    // Write the timestamp value and read it back.
                    await connection.CreateInsertOrUpdateCommand(_fixture.TableName,
                        new SpannerParameterCollection
                        {
                            new SpannerParameter("TimestampValue", SpannerDbType.Timestamp, timestamp),
                        }
                    ).ExecuteNonQueryAsync();
                    using (var reader = await connection.CreateSelectCommand($"SELECT TimestampValue FROM {_fixture.TableName}").ExecuteReaderAsync())
                    {
                        Assert.True(await reader.ReadAsync());
                        var dbTimestamp = reader.GetFieldValue<DateTime>("TimestampValue");
                        // Cloud Spanner always stores the timestamp in UTC, so if the original input value was
                        // a local time, we need to convert the value that we read in the database back to local time.
                        if (timestamp.Kind == DateTimeKind.Local)
                        {
                            dbTimestamp = dbTimestamp.ToLocalTime();
                        }
                        Assert.Equal(timestamp, dbTimestamp);
                        Assert.False(await reader.ReadAsync());
                    }
                }
            }
        }
    }
}
