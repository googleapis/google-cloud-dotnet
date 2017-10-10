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
        public async Task SelectAll()
        {
            using (var db = await _testFixture.CreateContextAsync())
            {
                var strings = await db.StringTable.ToListAsync();
                Assert.Equal(15, strings.Count);
            }
        }
    }
}
