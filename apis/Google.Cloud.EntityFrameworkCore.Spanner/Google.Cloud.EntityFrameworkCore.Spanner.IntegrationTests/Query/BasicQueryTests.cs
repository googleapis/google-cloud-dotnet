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

using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xunit;
using Xunit.Abstractions;

#endregion

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests.Query
{
    [Collection(nameof(TestDatabaseFixture))]
    public class BasicQueryTests
    {
        // ReSharper disable once UnusedParameter.Local
        public BasicQueryTests(TestDatabaseFixture testFixture, ITestOutputHelper outputHelper) => _testFixture =
            testFixture;

        private readonly TestDatabaseFixture _testFixture;

        [Fact(Skip = "test is too slow and is covered by EF specification tests.")]
        public async Task All()
        {
            using (var db = await _testFixture.CreateContextAsync(
                x => x?.StartsWith("SpannerCommand.ExecuteReader.Query") ?? false))
            {
                var strings = await db.StringTable.ToListAsync();
                Assert.Equal(15, strings.Count);
                Assert.Equal(
                    @"message:SpannerCommand.ExecuteReader.Query=SELECT s.Key, s.StringValue FROM StringTable AS s",
                    db.GetCurrentLog());
            }
        }

        [Fact(Skip = "test is too slow and is covered by EF specification tests.")]
        public async Task Any()
        {
            using (var db = await _testFixture.CreateContextAsync(
                x => x?.StartsWith("SpannerCommand.ExecuteReader.Query") ?? false))
            {
                var hasItem = await db.StringTable.AnyAsync(x => x.Key == "k5");
                Assert.Equal(true, hasItem);
                Assert.Equal(
                    @"message:SpannerCommand.ExecuteReader.Query=SELECT CASE     WHEN EXISTS (         SELECT 1         FROM StringTable AS x         WHERE x.Key = 'k5')     THEN TRUE ELSE FALSE END",
                    db.GetCurrentLog());

                db.ClearLog();
                hasItem = await db.StringTable.AnyAsync(x => x.Key == "k15");
                Assert.Equal(false, hasItem);
                Assert.Equal(
                    @"message:SpannerCommand.ExecuteReader.Query=SELECT CASE     WHEN EXISTS (         SELECT 1         FROM StringTable AS x         WHERE x.Key = 'k15')     THEN TRUE ELSE FALSE END",
                    db.GetCurrentLog());
            }
        }

        [Fact(Skip = "test is too slow and is covered by EF specification tests.")]
        public async Task AverageAsync()
        {
            using (var db = await _testFixture.CreateContextAsync(
                x => x?.StartsWith("SpannerCommand.ExecuteReader.Query") ?? false))
            {
                var average = await db.StringTable.AverageAsync(x => x.StringValue.Length);
                Assert.Equal((10 * 2D + 5 * 3D) / 15, average);
                Assert.Contains("SELECT AVG(CAST(CHAR_LENGTH(x.StringValue)", db.GetCurrentLog());
            }
        }


        [Fact(Skip = "test is too slow and is covered by EF specification tests.")]
        public async Task ContainsAsync()
        {
            using (var db = await _testFixture.CreateContextAsync(
                x => x?.StartsWith("SpannerCommand.ExecuteReader.Query") ?? false))
            {
                var containsValue = await db.StringTable.Select(x => x.StringValue).ContainsAsync("v1");
                Assert.Equal(true, containsValue);
                Assert.Equal(
                    @"message:SpannerCommand.ExecuteReader.Query=SELECT CASE     WHEN @__p_0 IN (         SELECT x.StringValue         FROM StringTable AS x     )     THEN TRUE ELSE FALSE END",
                    db.GetCurrentLog());

                db.ClearLog();
                containsValue = await db.StringTable.Select(x => x.StringValue).ContainsAsync("nonexistent_key");
                Assert.Equal(false, containsValue);
                Assert.Equal(
                    @"message:SpannerCommand.ExecuteReader.Query=SELECT CASE     WHEN @__p_0 IN (         SELECT x.StringValue         FROM StringTable AS x     )     THEN TRUE ELSE FALSE END",
                    db.GetCurrentLog());
            }
        }

        [Fact(Skip = "test is too slow and is covered by EF specification tests.")]
        public async Task FirstAsync()
        {
            using (var db = await _testFixture.CreateContextAsync(
                x => x?.StartsWith("SpannerCommand.ExecuteReader.Query") ?? false))
            {
                var firstEntry = await db.StringTable.Where(x => x.Key.StartsWith("k")).FirstAsync();
                Assert.StartsWith("k", firstEntry.Key);
                Assert.Contains("LIMIT 1", db.GetCurrentLog());
            }
        }

        [Fact(Skip = "test is too slow and is covered by EF specification tests.")]
        public async Task FirstOrDefaultNullAsync()
        {
            using (var db = await _testFixture.CreateContextAsync(
                x => x?.StartsWith("SpannerCommand.ExecuteReader.Query") ?? false))
            {
                var firstEntry = await db.StringTable.Where(x => x.Key.StartsWith("vk")).FirstOrDefaultAsync();
                Assert.Null(firstEntry);
                Assert.Contains("SELECT x.Key, x.StringValue FROM StringTable", db.GetCurrentLog());
            }
        }
    }
}