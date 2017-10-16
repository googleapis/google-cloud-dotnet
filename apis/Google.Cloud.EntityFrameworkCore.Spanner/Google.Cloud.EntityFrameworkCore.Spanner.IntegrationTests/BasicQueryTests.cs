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

using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xunit;
using Xunit.Abstractions;

#endregion

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests
{
    [Collection(nameof(TestDatabaseFixture))]
    public class BasicQueryTests
    {
        private readonly TestDatabaseFixture _testFixture;

        // ReSharper disable once UnusedParameter.Local
        public BasicQueryTests(TestDatabaseFixture testFixture, ITestOutputHelper outputHelper)
        {
            _testFixture = testFixture;
        }

        [Fact]
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

        [Fact]
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

        //TODO(benwu): review possible client side eval
        [Fact]
        public async Task AverageAsync()
        {
            using (var db = await _testFixture.CreateContextAsync(
                x => x?.StartsWith("SpannerCommand.ExecuteReader.Query") ?? false))
            {
                var average = await db.StringTable.AverageAsync(x => x.StringValue.Length);
                Assert.Equal((10 * 2D + 5 * 3D) / 15, average);
                Assert.Equal(
                    @"message:SpannerCommand.ExecuteReader.Query=SELECT x.StringValue FROM StringTable AS x",
                    db.GetCurrentLog());
            }
        }


        [Fact(Skip = "TODO: looks like a type conversion issue in sql gen bowels.")]
        public async Task ContainsAsync()
        {
            using (var db = await _testFixture.CreateContextAsync(
                x => x?.StartsWith("SpannerCommand.ExecuteReader.Query") ?? false))
            {
                var containsValue = await db.StringTable.ContainsAsync(new StringEntry
                {
                    Key = "k1",
                    StringValue = "nonexistent_but_shouldn't_matter_string"
                });
                Assert.Equal(true, containsValue);
                Assert.Equal(
                    @"message:SpannerCommand.ExecuteReader.Query=SELECT x.StringValue FROM StringTable AS x",
                    db.GetCurrentLog());

                db.ClearLog();
                containsValue = await db.StringTable.ContainsAsync(new StringEntry
                {
                    Key = "key_that_doesnt_exist",
                    StringValue = "nonexistent_but_shouldn't_matter_string"
                });
                Assert.Equal(false, containsValue);
                Assert.Equal(
                    @"message:SpannerCommand.ExecuteReader.Query=SELECT x.StringValue FROM StringTable AS x",
                    db.GetCurrentLog());
            }
        }
    }
}
