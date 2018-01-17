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

using System.Data.Common;
using Google.Cloud.Spanner.Data;
using Microsoft.EntityFrameworkCore.Query;
using Xunit;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests.Query
{
    public class FromSqlQuerySpannerTest : FromSqlQueryTestBase<NorthwindQuerySpannerFixture>
    {
        public FromSqlQuerySpannerTest(NorthwindQuerySpannerFixture fixture)
            : base(fixture)
        {
        }

        protected override DbParameter CreateDbParameter(string name, object value)
            => new SpannerParameter
            {
                ParameterName = name,
                Value = value
            };


        [Fact(Skip = "'Order' is a reserved word")]
        public override void Bad_data_error_handling_invalid_cast()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void Bad_data_error_handling_invalid_cast_key()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void Bad_data_error_handling_invalid_cast_no_tracking()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void Bad_data_error_handling_invalid_cast_projection()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void Bad_data_error_handling_null()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void Bad_data_error_handling_null_no_tracking()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void Bad_data_error_handling_null_projection()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void From_sql_annotations_do_not_affect_successive_calls()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void From_sql_composed_contains()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void From_sql_composed_contains2()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void From_sql_composed_with_nullable_predicate()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void From_sql_queryable_composed()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void From_sql_queryable_composed_after_removing_whitespaces()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void From_sql_queryable_composed_compiled()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void From_sql_queryable_composed_multiple_line_query()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void From_sql_queryable_multiple_composed()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void From_sql_queryable_multiple_composed_with_closure_parameters()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void From_sql_queryable_multiple_composed_with_parameters_and_closure_parameters()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void From_sql_queryable_multiple_composed_with_parameters_and_closure_parameters_interpolated()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void From_sql_queryable_multiple_line_query()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void From_sql_queryable_simple()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void From_sql_queryable_simple_as_no_tracking_not_composed()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void From_sql_queryable_simple_cache_key_includes_query_string()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void From_sql_queryable_simple_columns_out_of_order()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void From_sql_queryable_simple_columns_out_of_order_and_extra_columns()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void From_sql_queryable_simple_columns_out_of_order_and_not_enough_columns_throws()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void From_sql_queryable_simple_composed_include()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void From_sql_queryable_simple_include()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void From_sql_queryable_simple_projection_composed()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void From_sql_queryable_with_null_parameter()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void From_sql_queryable_with_parameters()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void From_sql_queryable_with_parameters_and_closure()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void From_sql_queryable_with_parameters_cache_key_includes_parameters()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void From_sql_queryable_with_parameters_inline()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void From_sql_queryable_with_parameters_inline_interpolated()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void From_sql_queryable_with_parameters_interpolated()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void From_sql_with_db_parameters_called_multiple_times()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void From_sql_with_dbParameter()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void From_sql_with_dbParameter_mixed()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void From_sql_with_join_and_include()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void From_sql_with_SelectMany_and_include()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void Include_closed_connection_opened_by_it_when_buffering()
        {
        }

        [Fact(Skip = "'Order' is a reserved word")]
        public override void Include_does_not_close_user_opened_connection_for_empty_result()
        {
        }
    }
}