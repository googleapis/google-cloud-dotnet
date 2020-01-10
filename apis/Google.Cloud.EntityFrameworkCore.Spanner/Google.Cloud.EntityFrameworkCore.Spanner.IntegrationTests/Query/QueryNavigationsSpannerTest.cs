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

using Microsoft.EntityFrameworkCore.Query;
using Xunit;
using Xunit.Abstractions;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests.Query
{
    public class QueryNavigationsSpannerTest : QueryNavigationsTestBase<NorthwindQuerySpannerFixture>
    {
        public QueryNavigationsSpannerTest(
            NorthwindQuerySpannerFixture fixture, ITestOutputHelper testOutputHelper)
            : base(fixture)
        {
            fixture.TestSqlLoggerFactory.Clear();
        }

        protected override void ClearLog()
            => Fixture.TestSqlLoggerFactory.Clear();

        [Fact(Skip = "https://github.com/aspnet/EntityFramework/issues/9039")]
        public override void Select_collection_navigation_multi_part()
        {
        }

        [Fact(Skip = "https://github.com/aspnet/EntityFramework/issues/9039")]
        public override void Select_collection_navigation_simple()
        {
        }
    }
}