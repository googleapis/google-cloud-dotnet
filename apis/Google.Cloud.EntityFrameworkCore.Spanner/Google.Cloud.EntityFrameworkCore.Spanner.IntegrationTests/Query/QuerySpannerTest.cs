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

using System;
using System.Linq;
using System.Text.RegularExpressions;
using Google.Cloud.Spanner.Data;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.TestModels.Northwind;
using Microsoft.EntityFrameworkCore.TestUtilities.Xunit;
using Xunit;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests.Query
{
    public class QuerySpannerTest : QueryTestBase<NorthwindQuerySpannerFixture>
    {
        public QuerySpannerTest(NorthwindQuerySpannerFixture fixture)
            : base(fixture)
        {
            Fixture.TestSqlLoggerFactory.Clear();
        }

        [ConditionalFact]
        public override void Select_distinct_average()
        {
            AssertSingleResult<Order>(os => os.Select(o => o.OrderID).Distinct().Average(),
                (e, a) => Assert.InRange((double) e - (double) a, -0.1D, 0.1D));
        }

        [ConditionalFact]
        public override void Average_with_no_arg()
        {
            //b/70403058
            AssertSingleResult<Order>(os => os.Select(o => o.OrderID).Average(),
                (e, a) => Assert.InRange((double) e - (double) a, -0.1D, 0.1D));
        }

        [ConditionalFact]
        public override void Average_with_binary_expression()
        {
            //b/70403058
            AssertSingleResult<Order>(os => os.Select(o => o.OrderID * 2).Average(),
                (e, a) => Assert.InRange((double) e - (double) a, -0.1D, 0.1D));
        }

        [ConditionalFact]
        public override void Average_with_arg()
        {
            //b/70403058
            AssertSingleResult<Order>(os => os.Average(o => o.OrderID),
                (e, a) => Assert.InRange((double) e - (double) a, -0.1D, 0.1D));
        }

        [ConditionalFact]
        public override void Average_with_arg_expression()
        {
            //b/70403058
            AssertSingleResult<Order>(os => os.Average(o => o.OrderID + o.OrderID),
                (e, a) => Assert.InRange((double) e - (double) a, -0.1D, 0.1D));
        }

        [ConditionalFact]
        public override void Average_with_division_on_decimal()
        {
            //b/70403058
            AssertSingleResult<OrderDetail>(
                ods => ods.Average(od => od.Quantity / 2.09m),
                (e, a) => Assert.InRange((decimal) e - (decimal) a, -0.1M, 0.1M));
        }

        [ConditionalFact]
        public override void Average_with_division_on_decimal_no_significant_digits()
        {
            //b/70403058
            AssertSingleResult<OrderDetail>(
                ods => ods.Average(od => od.Quantity / 2m),
                (e, a) => Assert.InRange((decimal) e - (decimal) a, -0.1M, 0.1M));
        }

        [ConditionalFact]
        public override void Average_with_coalesce()
        {
            //b/70403058
            AssertSingleResult<Product>(
                ps => ps.Where(p => p.ProductID < 40).Average(p => p.UnitPrice ?? 0),
                (e, a) => Assert.InRange((decimal) e - (decimal) a, -0.1M, 0.1M));
        }

        [ConditionalFact]
        public override void Average_over_subquery_is_client_eval()
        {
            //b/70403058
            AssertSingleResult<Customer>(cs => cs.Average(c => c.Orders.Sum(o => o.OrderID)),
                (e, a) => Assert.InRange((double) e - (double) a, -0.1D, 0.1D));
        }

        [ConditionalFact]
        public override void Average_on_float_column()
        {
            //b/70403058
            AssertSingleResult<OrderDetail>(ods => ods.Where(od => od.ProductID == 1).Average(od => od.Discount),
                (e, a) => Assert.InRange((float) e - (float) a, -0.1, 0.1));
        }

        private void AssertContainsInSql(string expected)
            => Assert.Contains(expected, Fixture.TestSqlLoggerFactory.Sql);

        protected override void ClearLog()
            => Fixture.TestSqlLoggerFactory.Clear();

        [Fact]
        public override void Contains_with_local_collection_sql_injection()
        {
            //a sql injection attempt should result in a spanner exception.
            string[] ids = {"ALFKI", "ABC')); GO; DROP TABLE Orders; GO; --"};

            Assert.Throws<SpannerException>(
                () =>
                    AssertQuery<Customer>(
                        cs =>
                            cs.Where(c => ids.Contains(c.CustomerID) || c.CustomerID == "ALFKI" ||
                                          c.CustomerID == "ABCDE"), entryCount: 1)
            );
        }

        [Fact]
        public override void IsNullOrWhiteSpace_in_predicate()
        {
            base.IsNullOrWhiteSpace_in_predicate();
            AssertContainsInSql("WHERE c.Region IS NULL OR (REGEXP_CONTAINS(c.Region, '^\\\\s*$')");
        }

        [Fact]
        public void IsNullOrWhiteSpace_in_predicate_with_newline()
        {
            using (var context = CreateContext())
            {
                var query = context.Set<Customer>()
                    .FirstOrDefault(c => string.IsNullOrWhiteSpace("\n"));
                Assert.NotNull(query);
            }
        }

        [Fact]
        public override void Query_expression_with_to_string_and_contains()
        {
            base.Query_expression_with_to_string_and_contains();
            AssertContainsInSql("STRPOS(CAST(o.EmployeeID AS STRING), '10') > 0");
        }

        [Fact]
        public void Regex_IsMatch()
        {
            AssertQuery<Customer>(
                cs => cs.Where(c => Regex.IsMatch(c.CompanyName, "^A")),
                entryCount: 4);
            AssertContainsInSql("WHERE REGEXP_CONTAINS(c.CompanyName, '^A')");
        }

        [Fact]
        public override void Select_non_matching_value_types_from_anonymous_type_introduces_explicit_cast()
        {
            //Overridden because "Order" is a reserved keyword in cloud spanner.
            AssertQuery<Order>(
                os => os
                    .Where(o => o.CustomerID == "ALFKI")
                    .OrderBy(o => o.OrderID)
                    .Select(o => new
                    {
                        LongOrder = (long) o.OrderID,
                        ShortOrder = (short) o.OrderID,
                        BaseOrder = o.OrderID
                    }),
                assertOrder: true);
        }

        [Fact]
        public override void String_Contains_Literal()
        {
            base.String_Contains_Literal();
            AssertContainsInSql("WHERE STRPOS(c.ContactName, 'M') > 0");
        }

        [Fact]
        public override void String_EndsWith_Literal()
        {
            base.String_EndsWith_Literal();
            AssertContainsInSql("WHERE ENDS_WITH");
        }

        [Fact]
        public void String_IndexOf_not_found()
        {
            AssertQuery<Customer>(
                cs => cs.Where(c => c.CompanyName.IndexOf("[") == -1),
                entryCount: 91);
            AssertContainsInSql("WHERE (STRPOS(c.CompanyName, '[') - 1) = -1");
        }

        [Fact]
        public void String_IndexOf_String()
        {
            AssertQuery<Customer>(
                cs => cs.Where(c => c.CompanyName.IndexOf("ar") > 5),
                entryCount: 13);
            AssertContainsInSql("WHERE (STRPOS(c.CompanyName, 'ar') - 1) > 5");
        }

        [Fact]
        public override void String_StartsWith_Column()
        {
            AssertQuery<Customer>(cs => cs.Where(c => c.ContactName.StartsWith(c.City)));
            AssertContainsInSql(
                @"STARTS_WITH");
        }

        [Fact]
        public override void String_StartsWith_Literal()
        {
            base.String_StartsWith_Literal();
            AssertContainsInSql("STARTS_WITH");
        }

        [Fact]
        public override void Trim_with_char_array_argument_in_predicate()
        {
            base.Trim_with_char_array_argument_in_predicate();
            AssertContainsInSql("WHERE TRIM(c.ContactTitle, 'Or')");
        }

        [Fact]
        public override void Trim_without_argument_in_predicate()
        {
            base.Trim_without_argument_in_predicate();
            AssertContainsInSql(@"WHERE TRIM");
        }

        [Fact]
        public override void TrimEnd_with_char_array_argument_in_predicate()
        {
            base.TrimEnd_with_char_array_argument_in_predicate();
            AssertContainsInSql("WHERE RTRIM(c.ContactTitle, 'er')");
        }

        [Fact]
        public override void TrimEnd_without_arguments_in_predicate()
        {
            base.TrimEnd_without_arguments_in_predicate();
            AssertContainsInSql("WHERE RTRIM");
        }

        [Fact]
        public override void TrimStart_with_char_array_argument_in_predicate()
        {
            base.TrimStart_with_char_array_argument_in_predicate();
            AssertContainsInSql("WHERE LTRIM(c.ContactTitle, 'Ow')");
        }

        [Fact]
        public override void TrimStart_without_arguments_in_predicate()
        {
            base.TrimStart_without_arguments_in_predicate();
            AssertContainsInSql("WHERE LTRIM");
        }

        [Fact]
        public override void Where_datetime_day_component()
        {
            base.Where_datetime_day_component();
            AssertContainsInSql("EXTRACT(DAY");
        }

        [Fact]
        public void Where_datetime_dayOfWeek_component()
        {
            AssertQuery<Order>(
                oc => oc.Where(o =>
                    o.OrderDate.Value.DayOfWeek == DayOfWeek.Tuesday),
                entryCount: 168);
            AssertContainsInSql("EXTRACT(DAYOFWEEK");
        }

        [Fact]
        public override void Where_datetime_dayOfYear_component()
        {
            base.Where_datetime_dayOfYear_component();
            AssertContainsInSql("EXTRACT(DAYOFYEAR");
        }

        [Fact]
        public override void Where_datetime_hour_component()
        {
            base.Where_datetime_hour_component();
            AssertContainsInSql("EXTRACT(HOUR");
        }

        // ReSharper disable once RedundantOverriddenMember
        [Fact]
        public override void Where_datetime_millisecond_component()
        {
            // SQL translation not implemented, too annoying
            base.Where_datetime_millisecond_component();
        }

        [Fact]
        public override void Where_datetime_minute_component()
        {
            base.Where_datetime_minute_component();
            AssertContainsInSql("EXTRACT(MINUTE");
        }

        [Fact]
        public override void Where_datetime_month_component()
        {
            base.Where_datetime_month_component();
            AssertContainsInSql("EXTRACT(MONTH");
        }

        [Fact]
        public override void Where_datetime_second_component()
        {
            base.Where_datetime_second_component();
            AssertContainsInSql("EXTRACT(SECOND");
        }

        [Fact]
        public override void Where_datetime_utcnow()
        {
            base.Where_datetime_utcnow();
            AssertContainsInSql("WHERE CURRENT_TIMESTAMP");
        }

        [Fact]
        public override void Where_datetime_year_component()
        {
            base.Where_datetime_year_component();
            AssertContainsInSql("EXTRACT(YEAR");
        }
    }
}