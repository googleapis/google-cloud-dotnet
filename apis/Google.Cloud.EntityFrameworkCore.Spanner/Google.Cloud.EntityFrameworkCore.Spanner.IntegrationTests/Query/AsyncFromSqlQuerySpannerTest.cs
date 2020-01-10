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

using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query;
using Xunit;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests.Query
{
    public class AsyncFromSqlQuerySpannerTest : AsyncFromSqlQueryTestBase<NorthwindQuerySpannerFixture>
    {
        public AsyncFromSqlQuerySpannerTest(NorthwindQuerySpannerFixture fixture)
            : base(fixture)
        {
        }

        [Fact(Skip = "FromSql test needs Spanner supported SQL")]
        public override Task From_sql_annotations_do_not_affect_successive_calls() => base
            .From_sql_annotations_do_not_affect_successive_calls();

        [Fact(Skip = "FromSql test needs Spanner supported SQL")]
        public override Task From_sql_composed_with_nullable_predicate() => base
            .From_sql_composed_with_nullable_predicate();

        [Fact(Skip = "FromSql test needs Spanner supported SQL")]
        public override Task From_sql_queryable_composed() => base.From_sql_queryable_composed();

        [Fact(Skip = "FromSql test needs Spanner supported SQL")]
        public override Task From_sql_queryable_composed_multiple_line_query() => base
            .From_sql_queryable_composed_multiple_line_query();

        [Fact(Skip = "FromSql test needs Spanner supported SQL")]
        public override Task From_sql_queryable_multiple_composed() => base.From_sql_queryable_multiple_composed();

        [Fact(Skip = "FromSql test needs Spanner supported SQL")]
        public override Task From_sql_queryable_multiple_composed_with_closure_parameters() => base
            .From_sql_queryable_multiple_composed_with_closure_parameters();

        [Fact(Skip = "FromSql test needs Spanner supported SQL")]
        public override Task From_sql_queryable_multiple_composed_with_parameters_and_closure_parameters() => base
            .From_sql_queryable_multiple_composed_with_parameters_and_closure_parameters();

        [Fact(Skip = "FromSql test needs Spanner supported SQL")]
        public override Task From_sql_queryable_multiple_line_query() => base.From_sql_queryable_multiple_line_query();

        [Fact(Skip = "FromSql test needs Spanner supported SQL")]
        public override Task From_sql_queryable_simple() => base.From_sql_queryable_simple();

        [Fact(Skip = "FromSql test needs Spanner supported SQL")]
        public override Task From_sql_queryable_simple_as_no_tracking_not_composed() => base
            .From_sql_queryable_simple_as_no_tracking_not_composed();

        [Fact(Skip = "FromSql test needs Spanner supported SQL")]
        public override Task From_sql_queryable_simple_cache_key_includes_query_string() => base
            .From_sql_queryable_simple_cache_key_includes_query_string();

        [Fact(Skip = "FromSql test needs Spanner supported SQL")]
        public override Task From_sql_queryable_simple_columns_out_of_order() => base
            .From_sql_queryable_simple_columns_out_of_order();

        [Fact(Skip = "FromSql test needs Spanner supported SQL")]
        public override Task From_sql_queryable_simple_columns_out_of_order_and_extra_columns() => base
            .From_sql_queryable_simple_columns_out_of_order_and_extra_columns();

        [Fact(Skip = "FromSql test needs Spanner supported SQL")]
        public override Task From_sql_queryable_simple_composed_include() => base
            .From_sql_queryable_simple_composed_include();

        [Fact(Skip = "FromSql test needs Spanner supported SQL")]
        public override Task From_sql_queryable_simple_include() => base.From_sql_queryable_simple_include();

        [Fact(Skip = "FromSql test needs Spanner supported SQL")]
        public override Task From_sql_queryable_simple_projection_not_composed() => base
            .From_sql_queryable_simple_projection_not_composed();

        [Fact(Skip = "FromSql test needs Spanner supported SQL")]
        public override Task From_sql_queryable_with_parameters() => base.From_sql_queryable_with_parameters();

        [Fact(Skip = "FromSql test needs Spanner supported SQL")]
        public override Task From_sql_queryable_with_parameters_and_closure() => base
            .From_sql_queryable_with_parameters_and_closure();

        [Fact(Skip = "FromSql test needs Spanner supported SQL")]
        public override Task From_sql_queryable_with_parameters_cache_key_includes_parameters() => base
            .From_sql_queryable_with_parameters_cache_key_includes_parameters();

        [Fact(Skip = "FromSql test needs Spanner supported SQL")]
        public override Task Include_closed_connection_opened_by_it_when_buffering() => base
            .Include_closed_connection_opened_by_it_when_buffering();

        [Fact(Skip = "FromSql test needs Spanner supported SQL")]
        public override Task Include_does_not_close_user_opened_connection_for_empty_result() => base
            .Include_does_not_close_user_opened_connection_for_empty_result();
    }
}