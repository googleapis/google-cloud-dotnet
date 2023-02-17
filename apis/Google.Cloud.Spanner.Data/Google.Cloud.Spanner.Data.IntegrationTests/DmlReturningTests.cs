// Copyright 2023 Google LLC
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
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [Collection(nameof(DmlTableFixture))]
    public class DmlReturningTests
    {
        private readonly DmlTableFixture _fixture;

        public DmlReturningTests(DmlTableFixture fixture) => _fixture = fixture;

        private readonly bool _disableTest = true; // TODO: Remove this flag once DML Returning code changes are compelte.

        [Fact]
        public async Task DMLReturn_ExecuteReader_Read()
        {
            if (_disableTest)
                return;

            string key = _fixture.CreateTestRows();
            var actualValues = new List<int>();

            using (var connection = _fixture.GetConnection())
            {
                await connection.OpenAsync();
                RetryHelpers.ExecuteWithRetry(async () =>
                {
                    string dml = $"UPDATE {_fixture.TableName} SET Value = OriginalValue + 1 WHERE UpdateMe AND Key=@key Then Return Value";
                    var command = connection.CreateDmlCommand(dml);
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            actualValues.Add(reader.GetFieldValue<int>(reader.GetOrdinal("Value")));
                        }
                    }
                });
            }
            var expectedValues = new List<int>() { 2, 5 };
            Assert.Equal(expectedValues, actualValues);
        }

        [Fact]
        public async Task DMLReturn_ExecuteReader_No_Read()
        {
            if (_disableTest)
                return;

            string key = _fixture.CreateTestRows();
            var actualValues = new List<int>();

            using (var connection = _fixture.GetConnection())
            {
                await connection.OpenAsync();
                RetryHelpers.ExecuteWithRetry(async () =>
                {
                    string dml = $"UPDATE {_fixture.TableName} SET Value = OriginalValue + 1 WHERE UpdateMe AND Key=@key Then Return Value";
                    var command = connection.CreateDmlCommand(dml);
                    var reader = await command.ExecuteReaderAsync();
                });
            }

            var actual = _fixture.FetchValues(key);
            var expected = new Dictionary<int, int>
            {
                { 0, 0 }, // Not updated
                { 1, 2 }, // Updated
                { 2, 2 }, // Not updated
                { 3, 3 }, // Not updated
                { 4, 5 }  // Updated
            };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public async Task DMLReturn_ExecuteNonQueryAsync()
        {
            if (_disableTest)
                return;

            string key = _fixture.CreateTestRows();
            using (var connection = _fixture.GetConnection())
            {
                await RetryHelpers.ExecuteWithRetryAsync(async () =>
                {
                    string dml = $"UPDATE {_fixture.TableName} SET Value = OriginalValue + 1 WHERE UpdateMe AND Key=@key Then Return Value";
                    using (var command = connection.CreateDmlCommand(dml))
                    {
                        command.Parameters.Add("key", SpannerDbType.String, key);
                        Assert.Equal(2, await command.ExecuteNonQueryAsync());
                    }
                });
            }
            var actual = _fixture.FetchValues(key);
            var expected = new Dictionary<int, int>
            {
                { 0, 0 }, // Not updated
                { 1, 2 }, // Updated
                { 2, 2 }, // Not updated
                { 3, 3 }, // Not updated
                { 4, 5 }  // Updated
            };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public async Task No_DMLReturn_ExecuteReader_Read()
        {
            if (_disableTest)
                return;

            string key = _fixture.CreateTestRows();
            var actualValues = new List<int>();

            using (var connection = _fixture.GetConnection())
            {
                await connection.OpenAsync();
                RetryHelpers.ExecuteWithRetry(async () =>
                {
                    string dml = $"UPDATE {_fixture.TableName} SET Value = OriginalValue + 1 WHERE UpdateMe AND Key=@key";
                    var command = connection.CreateDmlCommand(dml);
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            // TODO: Yet to decide behaviour.
                            //actualValues.Add(reader.GetFieldValue<int>(reader.GetOrdinal("Value")));
                        }
                    }
                });
            }
            var expectedValues = new List<int>() { 2, 5 };
            Assert.Equal(expectedValues, actualValues);
        }

        [Fact]
        public async Task No_DMLReturn_ExecuteReader_No_Read()
        {
            if (_disableTest)
                return;

            string key = _fixture.CreateTestRows();
            var actualValues = new List<int>();

            using (var connection = _fixture.GetConnection())
            {
                await connection.OpenAsync();
                RetryHelpers.ExecuteWithRetry(async () =>
                {
                    string dml = $"UPDATE {_fixture.TableName} SET Value = OriginalValue + 1 WHERE UpdateMe AND Key=@key";
                    var command = connection.CreateDmlCommand(dml);
                    var reader = await command.ExecuteReaderAsync(); // TODO: Yet to decide behaviour.
                });
            }

            var actual = _fixture.FetchValues(key);
            var expected = new Dictionary<int, int>
            {
                { 0, 0 }, // Not updated
                { 1, 2 }, // Updated
                { 2, 2 }, // Not updated
                { 3, 3 }, // Not updated
                { 4, 5 }  // Updated
            };
            Assert.Equal(expected, actual);
        }
    }
}
