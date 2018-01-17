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
using Microsoft.EntityFrameworkCore.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests.Query
{
    public class FiltersInheritanceSpannerTest : FiltersInheritanceTestBase<SpannerTestStore,
        FiltersInheritanceSpannerFixture>
    {
        public FiltersInheritanceSpannerTest(FiltersInheritanceSpannerFixture fixture,
            ITestOutputHelper testOutputHelper)
            : base(fixture)
        {
            Fixture.TestSqlLoggerFactory.Clear();
            //Fixture.TestSqlLoggerFactory.SetTestOutputHelper(testOutputHelper);
        }

        [Fact(Skip = "unknown")]
        public override void Can_use_derived_set()
        {
        }

        [Fact(Skip = "unknown")]
        public override void Can_use_IgnoreQueryFilters_and_GetDatabaseValues()
        {
        }

        [Fact(Skip = "unknown")]
        public override void Can_use_is_kiwi()
        {
        }

        [Fact(Skip = "unknown")]
        public override void Can_use_is_kiwi_in_projection()
        {
        }

        [Fact(Skip = "unknown")]
        public override void Can_use_is_kiwi_with_other_predicate()
        {
        }

        [Fact(Skip = "unknown")]
        public override void Can_use_of_type_animal()
        {
        }

        [Fact(Skip = "unknown")]
        public override void Can_use_of_type_bird()
        {
        }

        [Fact(Skip = "unknown")]
        public override void Can_use_of_type_bird_first()
        {
        }

        [Fact(Skip = "unknown")]
        public override void Can_use_of_type_bird_predicate()
        {
        }

        [Fact(Skip = "unknown")]
        public override void Can_use_of_type_bird_with_projection()
        {
        }

        [Fact(Skip = "unknown")]
        public override void Can_use_of_type_kiwi()
        {
        }
    }
}